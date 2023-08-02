using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CmlLib.Core.Auth.Microsoft;
using WolfLauncher.core;
using WolfLauncher.gui.launcher;
using WolfLauncher.model;
using MojangAPI.Model;

/**
 * Author: HypherionSA
 * Main Launcher Interface Window
 **/
namespace WolfLauncher
{
    public partial class MainLauncherForm : Form
    {
        // Static References
        private Launcher launcher = Launcher.INSTANCE;
        public static MainLauncherForm INSTANCE;

        public MainLauncherForm()
        {
            InitializeComponent();
            INSTANCE = this;

            this.Text = String.Format("{0} [{1}] - {2}", LauncherConstants.LauncherName, LauncherConstants.LauncherBuild, LauncherConstants.Version);
        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            SplashScreen splash = new SplashScreen();
            splash.ShowDialog(this);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Instance was double clicked, so we open the console window
            if (listView1.SelectedItems.Count > 0)
            {
                InstanceWindow instanceWindow = new InstanceWindow((Instance)listView1.SelectedItems[0].Tag);
                instanceWindow.ShowDialog(this);
            }
        }

        /**
         * Load instaces from drive
         **/
        public void loadInstances()
        {
            // Load from disk
            List<Instance> instances = launcher.loadInstances();
            listView1.Items.Clear();

            foreach (var i in instances)
            {
                // Set up listview item
                ListViewItem itm = new ListViewItem(i.name);
                itm.Tag = i;
                // TODO Custom Icons
                itm.ImageKey = "mclogo.png";
                listView1.Items.Add(itm);
            }
        }

        private void instanceMenu_Opening(object sender, CancelEventArgs e)
        {
            // If no instance was selected, we don't allow the menu to open
            if (listView1.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
                
            // Check if play and kill menu items can be enabled for the instance
            killToolStripMenuItem.Enabled = !(launcher.getRunning() == null || launcher.getRunning() != (Instance)listView1.SelectedItems[0].Tag);
            playToolStripMenuItem.Enabled = launcher.getRunning() == null;
        }

        /**
         * Delete Instance
         **/
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No instance was selected, so we return
            if (listView1.SelectedItems.Count == 0)
                return;

            // Show warning to user
            var res = MessageBox.Show("Are you sure? This action cannot be reversed", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // User accepted, so we nuke it
            if (res == DialogResult.Yes)
                Launcher.INSTANCE.deleteInstance((Instance)listView1.SelectedItems[0].Tag);
        }

        /**
         * Open Launcher Settings
         **/
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No instance was selected, so we return
            if (listView1.SelectedItems.Count == 0)
                return;

            // Display settings dialog.
            // TODO: Move this into console window
            InstanceSettings settings = new InstanceSettings((Instance)listView1.SelectedItems[0].Tag);
            settings.ShowDialog(this);
        }

        private void MainLauncherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kill running instance if any
            Launcher.INSTANCE.killInstance();
        }

        /**
         * Kill running instance
         **/
        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No instance was selected, so we return
            if (listView1.SelectedItems.Count == 0)
                return;

            // Micheal Meyers it! It must die
            launcher.killInstance();
        }

        /**
         * Launch Instance
         **/
        public void launchInstance(Instance ins = null)
        {
            // Launched from Console Window
            if (ins != null)
            {
                launcher.launch(this, ins);
                return;
            }

            // Launched from context menu
            if (listView1.SelectedItems.Count > 0)
            {
                launcher.launch(this, (model.Instance)listView1.SelectedItems[0].Tag);
            }
        }

        /**
         * Start Instance
         **/
        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launchInstance();
        }

        /**
         * Add new instance
         **/
        private void addInstanceButton_Click(object sender, EventArgs e)
        {
            // Show instance create dialog
            CreateVanillaInstance vanillaInstance = new CreateVanillaInstance();
            vanillaInstance.ShowDialog(this);
        }

        /**
         * Logout from signed in account
         **/
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Signout and refresh profile dropdown
            launcher.accountHandler().Signout();
            loadProfile();
        }

        /**
         * Load user profile information from the Mojang API
         **/
        public async void loadProfile()
        {
            // Check if any accounts are stored
            if (launcher.accountHandler().AccountManager.GetAccounts().Count > 0)
            {
                // Get first stored account
                var acc = launcher.accountHandler().AccountManager.GetAccounts().First();
                // Check authentication
                var s = launcher.accountHandler().Authenticate(acc);
                // Retrieve MC profile
                PlayerProfile profile = await launcher.getMojangApi().GetProfileUsingAccessToken(s.Result.AccessToken);

                // Set Dropdown text to profile name
                userDropdown.Text = profile.Name;

                // Set Profile Image
                userDropdown.Image = launcher.loadProfileImage(profile);
            }
            else
            {
                // No accounts are stored
                userDropdown.Text = "No Account";
            }
        }

        private void userDropdown_DropDownOpening(object sender, EventArgs e)
        {
            // No account is loaded or stored, so start login process
            if (userDropdown.Text == "No Account")
            {
                // Cancel dropdown
                userDropdown.AllowDrop = false;

                // Authenticate
                var loginHandler = JELoginHandlerBuilder.BuildDefault();
                loginHandler.Authenticate().Wait();

                // Refresh Dropdown
                loadProfile();
            }
        }
    }
}