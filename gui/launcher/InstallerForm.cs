using CmlLib.Core;
using CmlLib.Core.Downloader;
using CmlLib.Core.Files;
using CmlLib.Core.Installer.FabricMC;
using CmlLib.Core.Installer.Forge;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using WolfLauncher.core;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Instance Installer/Verifier
**/
namespace WolfLauncher.gui.launcher
{
    public partial class InstallerForm : Form
    {
        // References to Launcher instance
        private Launcher launcer = Launcher.INSTANCE;
        private Instance i;
        private CMLauncher l;

        public InstallerForm(Instance instance)
        {
            InitializeComponent();

            // Setup Variables
            i = instance;
            l = launcer.getCMLauncher();
            Control.CheckForIllegalCrossThreadCalls = false;

            this.Text = String.Format("{0} - {1} - {2}", "Preparing " + instance.name, LauncherConstants.LauncherName, LauncherConstants.Version);
        }

        private void InstallerForm_Load(object sender, EventArgs e)
        {
            // Register Event Listeners
            l.FileChanged += downloadFileChanged;
            l.ProgressChanged += downloadProgress;
        }

        private void downloadProgress(object sender, ProgressChangedEventArgs e)
        {
            // Update Progress Bar
            dlProgressbar.Value = e.ProgressPercentage;
        }

        private void downloadFileChanged(DownloadFileChangedEventArgs e)
        {
            // Verification, so we ignore
            if (e.Source is IFileChecker)
                return;

            try
            {
                // Update progress label
                downloadLabel.Text = "Downloading " + e.FileKind.ToString() + " - " + e.ProgressedFileCount + "/" + e.TotalFileCount + " files";
            }
            catch { }
        }

        private void InstallerForm_Shown(object sender, EventArgs e)
        {
            // Start Installation/Verifaction Process
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Check if we should install a loader
            if (i.loader != null && i.loader != "none")
            {

                // Instance requires forge
                if (i.loader.Contains("forge:"))
                {
                    // Parse forge version from manifest
                    var loader = i.loader.Replace("forge:", "");
                    LauncherLogger.INSTANCE.addLog("Installing Forge " + loader);

                    // Install Forge
                    var forge = new MForge(l);
                    forge.ProgressChanged += downloadProgress;
                    forge.FileChanged += downloadFileChanged;
                    forge.Install(i.gameVersion, loader).Wait();
                    l.GetAllVersions();
                }

                // Instance requires Fabric
                if (i.loader.Contains("fabric:"))
                {
                    // Parse fabric version from manifest
                    var loader = i.loader.Replace("fabric:", "");
                    LauncherLogger.INSTANCE.addLog("Installing Fabric " + loader);

                    // Install Fabric
                    var fabricLoader = new FabricVersionLoader();
                    var fabricV = await fabricLoader.GetVersionMetadatasAsync();
                    var fabric = fabricV.GetVersionMetadata(loader);
                    fabric.Save(l.MinecraftPath);

                    // Vanilla Install
                    l.CheckAndDownload(l.GetVersion(i.gameVersion));
                    l.GetAllVersions();
                }
            } else
            {
                // Vanilla Install
                l.CheckAndDownload(l.GetVersion(i.gameVersion));
                l.GetAllVersions();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Progress is finished, so we remove listeners
            l.FileChanged -= downloadFileChanged;
            l.ProgressChanged -= downloadProgress;

            // Wait for all threads to shut down and close the dialog
            Thread.Sleep(1000);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void InstallerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Worker is busy, so form cannot be closed
            if (backgroundWorker1.IsBusy)
                e.Cancel = true;
        }
    }
}
