using System;
using System.Windows.Forms;
using WolfLauncher.core;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Instance settings dialog like Ram, JVM args, Screensize etc
 **/
namespace WolfLauncher.gui.launcher
{
    public partial class InstanceSettings : Form
    {
        // Reference to launcher instance
        private Instance instance;

        public InstanceSettings(Instance ins)
        {
            InitializeComponent();

            instance = ins;
            this.Text = String.Format("{0} - {1} - {2}", "Settings for " + ins.name, LauncherConstants.LauncherName, LauncherConstants.Version);
        }

        /**
         * Read instance settings from manifest
         **/
        private void InstanceSettings_Load(object sender, EventArgs e)
        {
            // Get system information
            var i = new Microsoft.VisualBasic.Devices.ComputerInfo();

            // Set max ram values. Adds in a buffer so you still have memory left for the OS
            maxRam.Maximum = i.TotalPhysicalMemory / (1024 * 1024) - 1024;
            minRam.Maximum = maxRam.Maximum / 2;

            // Check if instance has settings, otherwise apply defaults
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

            // Set values from manifest
            maxRam.Value = instance.settings.maxRam;
            minRam.Value = instance.settings.minRam;
            jvmArgs.Text = instance.settings.javaArgs;
            screenWidth.Text = instance.settings.screenWidth;
            screenHeight.Text = instance.settings.screenHeight;
        }

        /**
         * Persist Settings to instance manifest
         **/
        private void saveSettings_Click(object sender, EventArgs e)
        {
            // Add values to manifest
            instance.settings.maxRam = (int)maxRam.Value;
            instance.settings.minRam = (int)minRam.Value;
            instance.settings.javaArgs = jvmArgs.Text;
            instance.settings.screenWidth = screenWidth.Text;
            instance.settings.screenHeight = screenHeight.Text;

            // Save Settings
            Launcher.INSTANCE.updateInstanceSettings(instance);

            MessageBox.Show("Settings Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
