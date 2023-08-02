namespace WolfLauncher
{
    partial class MainLauncherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLauncherForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.instanceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instanceIconList = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.addInstanceButton = new System.Windows.Forms.ToolStripButton();
            this.foldersButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewLauncherFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInstanceFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.helpButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.userDropdown = new System.Windows.Forms.ToolStripDropDownButton();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instanceMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.instanceMenu;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.instanceIconList;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 400);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // instanceMenu
            // 
            this.instanceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.toolStripSeparator1,
            this.playToolStripMenuItem,
            this.killToolStripMenuItem,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.instanceMenu.Name = "instanceMenu";
            this.instanceMenu.Size = new System.Drawing.Size(117, 126);
            this.instanceMenu.Opening += new System.ComponentModel.CancelEventHandler(this.instanceMenu_Opening);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // instanceIconList
            // 
            this.instanceIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("instanceIconList.ImageStream")));
            this.instanceIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.instanceIconList.Images.SetKeyName(0, "mclogo.png");
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInstanceButton,
            this.foldersButton,
            this.settingsButton,
            this.helpButton,
            this.userDropdown});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 25);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "toolStrip1";
            // 
            // addInstanceButton
            // 
            this.addInstanceButton.Image = ((System.Drawing.Image)(resources.GetObject("addInstanceButton.Image")));
            this.addInstanceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInstanceButton.Name = "addInstanceButton";
            this.addInstanceButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.addInstanceButton.Size = new System.Drawing.Size(96, 22);
            this.addInstanceButton.Text = "Add Instance";
            this.addInstanceButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addInstanceButton.Click += new System.EventHandler(this.addInstanceButton_Click);
            // 
            // foldersButton
            // 
            this.foldersButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLauncherFolderToolStripMenuItem,
            this.viewInstanceFolderToolStripMenuItem});
            this.foldersButton.Image = ((System.Drawing.Image)(resources.GetObject("foldersButton.Image")));
            this.foldersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.foldersButton.Name = "foldersButton";
            this.foldersButton.Size = new System.Drawing.Size(74, 22);
            this.foldersButton.Text = "Folders";
            // 
            // viewLauncherFolderToolStripMenuItem
            // 
            this.viewLauncherFolderToolStripMenuItem.Name = "viewLauncherFolderToolStripMenuItem";
            this.viewLauncherFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewLauncherFolderToolStripMenuItem.Text = "View Launcher Folder";
            // 
            // viewInstanceFolderToolStripMenuItem
            // 
            this.viewInstanceFolderToolStripMenuItem.Name = "viewInstanceFolderToolStripMenuItem";
            this.viewInstanceFolderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewInstanceFolderToolStripMenuItem.Text = "View Instance Folder";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(69, 22);
            this.settingsButton.Text = "Settings";
            // 
            // helpButton
            // 
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(61, 22);
            this.helpButton.Text = "Help";
            // 
            // userDropdown
            // 
            this.userDropdown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountsToolStripMenuItem,
            this.toolStripSeparator3,
            this.logoutToolStripMenuItem});
            this.userDropdown.Image = ((System.Drawing.Image)(resources.GetObject("userDropdown.Image")));
            this.userDropdown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.userDropdown.Name = "userDropdown";
            this.userDropdown.Size = new System.Drawing.Size(100, 22);
            this.userDropdown.Text = "No Account";
            this.userDropdown.DropDownOpening += new System.EventHandler(this.userDropdown_DropDownOpening);
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MainLauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainLauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wolf Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainLauncherForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.instanceMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip instanceMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripButton addInstanceButton;
        private System.Windows.Forms.ToolStripDropDownButton foldersButton;
        private System.Windows.Forms.ToolStripMenuItem viewLauncherFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInstanceFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripDropDownButton helpButton;
        private System.Windows.Forms.ToolStripDropDownButton userDropdown;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ImageList instanceIconList;
    }
}

