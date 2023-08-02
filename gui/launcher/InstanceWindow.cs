using System;
using System.Windows.Forms;
using WolfLauncher.core;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Console window for instances
 **/
namespace WolfLauncher.gui.launcher
{
    public partial class InstanceWindow : Form
    {
        // Reference to launcher instance
        private Instance instance;

        public InstanceWindow(Instance ins)
        {
            InitializeComponent();
            this.instance = ins;

            this.Text = String.Format("{0} - {1} - {2}", "Console window for " + ins.name, LauncherConstants.LauncherName, LauncherConstants.Version);
        }

        private void wrapLines_CheckedChanged(object sender, EventArgs e)
        {
            // Apply wordwrapping based on checkbox
            logWindow.WordWrap = wrapLines.Checked;
        }

        private void InstanceWindow_Load(object sender, EventArgs e)
        {
            // Setup default values
            logWindow.WordWrap = wrapLines.Checked;

            // Load log from logger if it exists
            LauncherLogger.INSTANCE.logWindow = this.logWindow;
            LauncherLogger.INSTANCE.loadLog(instance);
            LauncherLogger.INSTANCE.canUpdateLog = true;
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            // Clear the log
            logWindow.Clear();
            LauncherLogger.INSTANCE.clearLog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the window... Really? I needed to comment this??
            this.Close();
        }

        private void launchBtn_Click(object sender, EventArgs e)
        {
            // Launch Instance
            MainLauncherForm.INSTANCE.launchInstance(instance);
        }

        private void updateLog_CheckedChanged(object sender, EventArgs e)
        {
            // Set if log can be updated in the window or not
            LauncherLogger.INSTANCE.canUpdateLog = updateLog.Checked;
        }
    }
}
