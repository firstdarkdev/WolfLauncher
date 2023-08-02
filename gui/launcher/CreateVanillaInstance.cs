using CmlLib.Core;
using CmlLib.Core.Installer.FabricMC;
using CmlLib.Core.Installer.Forge.Versions;
using CmlLib.Core.Version;
using CmlLib.Core.VersionLoader;
using CmlLib.Core.VersionMetadata;
using Semver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WolfLauncher.core;
using WolfLauncher.model;

/**
 * Author: HypherionSA
 * Instance Creation dialog
 **/
namespace WolfLauncher.gui.launcher
{
    public partial class CreateVanillaInstance : Form
    {
        // Set launcher instance
        private Launcher launcher = Launcher.INSTANCE;
        private CMLauncher l;

        // Cache
        private List<ListViewItem> items = new List<ListViewItem>();
        private ListViewItem lastItem;
        
        // First MC version that supports fabric
        private SemVersion fabricLowest = SemVersion.Parse("1.14.2");

        public CreateVanillaInstance()
        {
            InitializeComponent();
            l = launcher.getCMLauncher();
            l.VersionLoader = new MojangVersionLoader();

            this.Text = String.Format("{0} - {1} - {2}", "Create Instance", LauncherConstants.LauncherName, LauncherConstants.Version);
        }

        private async void CreateVanillaInstance_Load(object sender, EventArgs e)
        {
            // Get game versions
            MVersionCollection versions = await l.GetAllVersionsAsync();
            versionsList.Items.Clear();

            // Load Versions into list
            foreach(MVersionMetadata meta in versions)
            {
                ListViewItem itm = new ListViewItem(meta.Name);
                itm.SubItems.Add(meta.ReleaseTimeStr);
                itm.SubItems.Add(meta.Type);
                versionsList.Items.Add(itm);
                items.Add(itm);
            }

            // Apply version filtering
            sortItems();
        }

        private void sortItems()
        {
            // Clear List
            versionsList.Items.Clear();

            foreach (ListViewItem itm in items)
            {
                // Release Version
                if (itm.SubItems[2].Text.Equals("release") && releasesCheck.Checked)
                    versionsList.Items.Add(itm);

                // Snapshot Version
                if (itm.SubItems[2].Text.Equals("snapshot") && snapshotsCheck.Checked)
                    versionsList.Items.Add(itm);

                // Beta Version
                if (itm.SubItems[2].Text.Equals("old_beta") && betasCheck.Checked)
                    versionsList.Items.Add(itm);

                // Alpha version
                if (itm.SubItems[2].Text.Equals("old_alpha") && alphasCheck.Checked)
                    versionsList.Items.Add(itm);
            }

            // Select first item in list
            if (versionsList.Items.Count > 0)
                versionsList.Items[0].Selected = true;
        }

        private void releasesCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Apply Filter
            sortItems();
        }

        private void snapshotsCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Apply Filter
            sortItems();
        }

        private void betasCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Apply Filter
            sortItems();
        }

        private void alphasCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Apply Filter
            sortItems();
        }

        /**
         * Selected version changed. Update Loaders list if needed
         **/
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (versionsList.SelectedItems.Count > 0)
            {
                // Refresh Forge
                if (forgeLoader.Checked)
                    loadForge();

                // Refresh Fabric
                if (fabricLoader.Enabled && fabricLoader.Checked)
                    loadFabric();

                // Update instance name, if the user didn't change it
                ListViewItem sel = versionsList.SelectedItems[0];
                if (lastItem == null || instanceName.Text == lastItem.Text || String.IsNullOrEmpty(instanceName.Text))
                {
                    instanceName.Text = sel.Text;
                    lastItem = sel;
                }

                // Load fabric versions if available
                try
                {
                    SemVersion currentVer = SemVersion.Parse(sel.Text);
                    fabricLoader.Enabled = currentVer.ComparePrecedenceTo(fabricLowest) >= 0;
                } catch
                {
                    fabricLoader.Enabled = true;
                }
            }
        }

        /**
         * Load and Filter forge versions
         **/
        private async void loadForge()
        {
            // Clear dropdown
            loaderDropdown.Items.Clear();

            try
            {
                // Load Forge Versions for selected minecraft version
                var forgeLoader = new ForgeVersionLoader(new System.Net.Http.HttpClient());
                var versions = await forgeLoader.GetForgeVersions(versionsList.SelectedItems[0].Text);
                var recommended = versions.First(v => v.IsRecommendedVersion);

                foreach (var version in versions)
                {
                    // Mark item as recommended if it is
                    String ver = version.ForgeVersionName;
                    if (recommended != null && version.ForgeVersionName == recommended.ForgeVersionName)
                        ver += " (Recommended)";

                    // Add item to dropdown
                    loaderDropdown.Items.Add(ver);
                }

            } catch { }
        }

        /**
         * Load Fabric Versions
         **/
        private async void loadFabric()
        {
            // Clear dropdown
            loaderDropdown.Items.Clear();

            // Load Fabric Versions
            var fabricLoader = new FabricVersionLoader();
            var fabricVersions = await fabricLoader.GetVersionMetadatasAsync();

            foreach (var v in fabricVersions)
            {
                // Add item to dropdown
                loaderDropdown.Items.Add(v.Name);
            }
        }

        /**
         * Forge radio checked, so we refresh forge
         **/
        private void forgeLoader_CheckedChanged(object sender, EventArgs e)
        {
            if (forgeLoader.Checked)
                loadForge();
        }

        /**
         * Set up instance meta data ready to be written to the disk
         **/
        private void createInstance_Click(object sender, EventArgs e)
        {
            // Create new instance manifest
            Instance instance = new Instance();

            // Set game version for instance
            instance.gameVersion = versionsList.SelectedItems[0].Text;
            // Set instance name
            instance.name = instanceName.Text;

            // Local install. This instance will be ignored from update checkers
            instance.localInstall = true;

            // Check if a mod loader should be installed
            if (loaderDropdown.Items.Count > 0 && loaderDropdown.SelectedItem != null)
            {
                // Loader is forge
                if (forgeLoader.Checked)
                    instance.loader = "forge:" + loaderDropdown.SelectedItem.ToString().Replace(" (Recommended)", "");

                // Loader is fabric
                if (fabricLoader.Checked)
                    instance.loader = "fabric:" + loaderDropdown.SelectedItem.ToString();
            }

            // Set default settings for instance
            instance.settings = new Instance.Settings
            {
                maxRam = 2024,
                minRam = 512,
                screenHeight = "auto",
                screenWidth = "auto",
                javaPath = "",
                javaArgs = ""
            };

            // Persist to disk
            var s = launcher.install(instance);

            // Close the window if the instance was created
            if (s)
                this.Close();
        }

        private void fabricLoader_CheckedChanged(object sender, EventArgs e)
        {
            // Fabric selected, load fabric versions
            if (fabricLoader.Checked)
                loadFabric();
        }
    }
}
