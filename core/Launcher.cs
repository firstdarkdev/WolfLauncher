using CmlLib.Core;
using CmlLib.Core.Auth.Microsoft;
using MojangAPI;
using MojangAPI.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using WolfLauncher.gui.launcher;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Core Launcher Logic
 **/
namespace WolfLauncher.core
{
    public class Launcher
    {
        // Static instance that can be accessed from anywhere
        public static Launcher INSTANCE = new Launcher();

        // Authentication and Launcher Library initialization
        private JELoginHandler loginHandler = JELoginHandlerBuilder.BuildDefault();
        private CMLauncher cmLauncher;
        private Mojang mojang = new Mojang(new HttpClient());

        // Launcher Directories
        private DirectoryInfo dataDir = new DirectoryInfo("launcherdata");
        private DirectoryInfo mcDir = new DirectoryInfo("launcherdata/minecraft");
        private MinecraftPath mcPath;
        private FileInfo log4jFile = new FileInfo("launcherdata/log-config.xml");

        // Monitoring running instance
        private Instance runningInstance;
        private Process runningProccess;
        Timer tmr;

        private Launcher() {
            // Check if directories exist, and create them if they don't
            if (!dataDir.Exists)
                dataDir.Create();

            if (!mcDir.Exists)
                mcDir.Create();

            if (!log4jFile.Exists)
                File.WriteAllText(log4jFile.FullName, "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<Configuration status=\"WARN\">\r\n    <Appenders>\r\n        <Console name=\"SysOut\" target=\"SYSTEM_OUT\">\r\n            <PatternLayout pattern=\"[%d{HH:mm:ss}] [%t/%level]: %msg{nolookups}%n\" />\r\n        </Console>\r\n        <RollingRandomAccessFile name=\"File\" fileName=\"logs/latest.log\" filePattern=\"logs/%d{yyyy-MM-dd}-%i.log.gz\">\r\n            <PatternLayout pattern=\"[%d{HH:mm:ss}] [%t/%level]: %msg{nolookups}%n\" />\r\n            <Policies>\r\n                <TimeBasedTriggeringPolicy />\r\n                <OnStartupTriggeringPolicy />\r\n            </Policies>\r\n        </RollingRandomAccessFile>\r\n    </Appenders>\r\n    <Loggers>\r\n        <Root level=\"info\">\r\n            <filters>\r\n                <MarkerFilter marker=\"NETWORK_PACKETS\" onMatch=\"DENY\" onMismatch=\"NEUTRAL\" />\r\n            </filters>\r\n            <AppenderRef ref=\"SysOut\"/>\r\n            <AppenderRef ref=\"File\"/>\r\n        </Root>\r\n    </Loggers>\r\n</Configuration>");

            // Setup library and minecraft paths
            mcPath = new MinecraftPath(mcDir.ToString());
            cmLauncher = new CMLauncher(mcPath);

            // Used to enable kill button on running instance
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += (s, e) =>
            {
                if (runningInstance != null && runningProccess != null)
                {
                    if (runningProccess.HasExited)
                    {
                        runningInstance = null;
                        tmr.Enabled = false;
                    }
                } else
                {
                    runningInstance = null;
                    tmr.Enabled = false;
                }
            };
        }

        /**
         * Save instance configuration to drive, ready for install
         **/
        public bool install(Instance instance)
        {
            DirectoryInfo instancePath = new DirectoryInfo("instances/" + instance.name);

            // Instances are saved by name, so we check if the directory already exists
            if (!instancePath.Exists)
            {
                // New instance, so we create the folder and write the instance config
                instancePath.Create();
                File.WriteAllText(@instancePath.FullName + "\\instance.json", JsonConvert.SerializeObject(instance));
                MainLauncherForm.INSTANCE.loadInstances();
                return true;
            } else
            {
                // Duplicate launcher
                MessageBox.Show("Instance Already Exists!", "Instance Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        /**
         * Launch an instance. This will also verify that the instance is still valid
         **/
        public async void launch(Form parent, Instance instance)
        {
            runningInstance = instance;
            LauncherLogger.INSTANCE.startLogging(instance);
            LauncherLogger.INSTANCE.addLog("Launching " + instance.name + " with version " + instance.gameVersion);

            // Create installer/verification form
            InstallerForm installer = new InstallerForm(instance);
            var res = installer.ShowDialog(parent);

            // Installer process completed, so we continue to launching
            if (res == DialogResult.OK)
            {
                // Load the instance (or data) directory of the instance
                DirectoryInfo instanceDir = new DirectoryInfo("instances/" + instance.name);
                
                // Modify the Minecraft path so we can store data in the instance folder, but share assets and game files across multiple instances
                MinecraftPath p = new MinecraftPath();
                p.BasePath = instanceDir.FullName;
                p.Assets = mcPath.Assets;
                p.Versions = mcPath.Versions;
                p.Library = mcPath.Library;
                p.Resource = mcPath.Resource;
                p.Runtime = mcPath.Runtime;

                if (instance.settings == null)
                {
                    instance.settings = new Instance.Settings
                    {
                        maxRam = 2024,
                        minRam = 512,
                        screenHeight = "auto",
                        screenWidth = "auto",
                        javaPath = "",
                        javaArgs = ""
                    };
                }

                // Setup Launcher Values
                var options = new MLaunchOption
                {
                    Path = p,
                    MaximumRamMb = instance.settings.maxRam,
                    MinimumRamMb = instance.settings.minRam,
                    Session = loginHandler.AuthenticateSilently().Result,
                    GameLauncherName = LauncherConstants.LauncherName,
                    GameLauncherVersion = LauncherConstants.Version
                };

                if (instance.settings.screenWidth != "auto")
                    options.ScreenWidth = int.Parse(instance.settings.screenWidth);

                if (instance.settings.screenHeight != "auto")
                    options.ScreenHeight = int.Parse(instance.settings.screenWidth);

                if (!String.IsNullOrEmpty(instance.settings.javaPath))
                    options.JavaPath = instance.settings.javaPath;

                if (!String.IsNullOrEmpty(instance.settings.javaArgs))
                    options.JVMArguments = new string[] { instance.settings.javaArgs };

                Process process;

                // Set up the launcher process
                try
                {
                    process = await cmLauncher.CreateProcessAsync(parseLoader(instance), options, checkAndDownload: true);
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Failed to launch instance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Just a safety catch
                if (process == null)
                {
                    runningInstance = null;
                    return;
                }

                // Setup console relay to log window
                process.OutputDataReceived += (s, e) =>
                {
                    LauncherLogger.INSTANCE.addLog(e.Data);
                };

                process.ErrorDataReceived += (s, e) =>
                {
                    LauncherLogger.INSTANCE.addLog(e.Data);
                };

                // Enable console redirects
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;
                process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
                process.EnableRaisingEvents = true;

                // Replace log4j config, so that we can actually read it to the console
                var arg = process.StartInfo.Arguments;
                if (arg.IndexOf("-Dlog4j.configurationFile=") != 0)
                {
                    var rep = arg.Substring(arg.IndexOf("-Dlog4j.configurationFile="));
                    rep = rep.Substring(0, rep.IndexOf(" "));
                    arg = arg.Replace(rep, "-Dlog4j.configurationFile=" + log4jFile.FullName);
                    process.StartInfo.Arguments = arg;
                }

                // Launch the game
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();
                runningProccess = process;
                tmr.Enabled = true;
            }
        }

        /**
         * Load instances from instances folder
         **/
        public List<Instance> loadInstances()
        {
            List<Instance> instances = new List<Instance>();
            DirectoryInfo instancesDir = new DirectoryInfo("instances");

            // Check if launcher contains any instances
            if (instancesDir.Exists)
            {
                foreach(var di in instancesDir.GetDirectories())
                {
                    try
                    {
                        // Load instance configuration file
                        FileInfo ins = new FileInfo(@di.FullName + "\\instance.json");

                        if (ins.Exists)
                        {
                            // Read instance configuration
                            Instance instance = JsonConvert.DeserializeObject<Instance>(File.ReadAllText(@ins.FullName));

                            // Validate that file loaded correctly and add to instance list
                            if (instance != null)
                            {
                                instances.Add(instance);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            }

            return instances;
        }

        /**
         * Converts Minecraft and Loader string into correct game version
         **/
        private string parseLoader(Instance i)
        {
            var returnVer = i.gameVersion;

            // Check if instance uses a loader, if not, we return the vanilla version
            if (i.loader != null && i.loader != "none")
            {

                // Loader is forge
                if (i.loader.StartsWith("forge:"))
                {
                    var loader = i.loader.Replace("forge:", "");
                    returnVer += "-forge-" + loader;
                }

                if (i.loader.StartsWith("fabric:"))
                {
                    var loader = i.loader.Replace("fabric:", "");
                    returnVer = loader;
                }
            }

            return returnVer;
        }

        /**
         * Remove an instance from the drive
         **/
        public void deleteInstance(Instance instance)
        {
            try {
                // Delete the instance folder and reload instances in main window
                DirectoryInfo instancesDir = new DirectoryInfo("instances\\" + instance.name);
                Directory.Delete(instancesDir.FullName, true);
                MainLauncherForm.INSTANCE.loadInstances();
            } catch (Exception e)
            {
                MessageBox.Show("Failed to delete instance: " + e.Message, "Failed to remove instance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * Write instance settings to drive
         **/
        public void updateInstanceSettings(Instance instance)
        {
            FileInfo ins = new FileInfo("instances\\" + instance.name + "\\instance.json");
            File.WriteAllText(ins.FullName, JsonConvert.SerializeObject(instance));
            MainLauncherForm.INSTANCE.loadInstances();
        }

        /**
         * Kill a running instance. Called when KILL button is clicked, or launcher is closed
         **/
        public void killInstance()
        {
            if (runningProccess == null || runningProccess.HasExited)
                return;

            runningProccess.Kill();
        }

        /**
         * Load Player head from skin to display in accounts sections
         **/
        public Image loadProfileImage(PlayerProfile p)
        {
            // Download the player head and convert it to an image object
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData("https://mc-heads.net/avatar/" + p.UUID);
            return Image.FromStream(new MemoryStream(imageData));
        }

        public MinecraftPath getMinecraftPath()
        {
            return mcPath;
        }

        public CMLauncher getCMLauncher()
        {
            return cmLauncher;
        }

        public Instance getRunning()
        {
            return this.runningInstance;
        }

        public JELoginHandler accountHandler()
        {
            return this.loginHandler;
        }

        public Mojang getMojangApi()
        {
            return this.mojang;
        }
    }
}
