namespace WolfLauncher.gui.launcher
{
    partial class CreateVanillaInstance
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
            this.versionsList = new System.Windows.Forms.ListView();
            this.mcVer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterLabel = new System.Windows.Forms.Label();
            this.releasesCheck = new System.Windows.Forms.CheckBox();
            this.snapshotsCheck = new System.Windows.Forms.CheckBox();
            this.betasCheck = new System.Windows.Forms.CheckBox();
            this.alphasCheck = new System.Windows.Forms.CheckBox();
            this.loaderLabel = new System.Windows.Forms.Label();
            this.noLoader = new System.Windows.Forms.RadioButton();
            this.forgeLoader = new System.Windows.Forms.RadioButton();
            this.fabricLoader = new System.Windows.Forms.RadioButton();
            this.liteLoader = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.instanceName = new System.Windows.Forms.TextBox();
            this.createInstance = new System.Windows.Forms.Button();
            this.loaderVersionLabel = new System.Windows.Forms.Label();
            this.loaderDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // versionsList
            // 
            this.versionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mcVer,
            this.releaseDate,
            this.releaseType});
            this.versionsList.FullRowSelect = true;
            this.versionsList.HideSelection = false;
            this.versionsList.Location = new System.Drawing.Point(12, 43);
            this.versionsList.Name = "versionsList";
            this.versionsList.Size = new System.Drawing.Size(358, 240);
            this.versionsList.TabIndex = 0;
            this.versionsList.UseCompatibleStateImageBehavior = false;
            this.versionsList.View = System.Windows.Forms.View.Details;
            this.versionsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // mcVer
            // 
            this.mcVer.Text = "Version";
            this.mcVer.Width = 142;
            // 
            // releaseDate
            // 
            this.releaseDate.Text = "Released";
            this.releaseDate.Width = 93;
            // 
            // releaseType
            // 
            this.releaseType.Text = "Type";
            this.releaseType.Width = 103;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(388, 43);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(29, 13);
            this.filterLabel.TabIndex = 1;
            this.filterLabel.Text = "Filter";
            // 
            // releasesCheck
            // 
            this.releasesCheck.AutoSize = true;
            this.releasesCheck.Checked = true;
            this.releasesCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.releasesCheck.Location = new System.Drawing.Point(391, 63);
            this.releasesCheck.Name = "releasesCheck";
            this.releasesCheck.Size = new System.Drawing.Size(70, 17);
            this.releasesCheck.TabIndex = 2;
            this.releasesCheck.Text = "Releases";
            this.releasesCheck.UseVisualStyleBackColor = true;
            this.releasesCheck.CheckedChanged += new System.EventHandler(this.releasesCheck_CheckedChanged);
            // 
            // snapshotsCheck
            // 
            this.snapshotsCheck.AutoSize = true;
            this.snapshotsCheck.Location = new System.Drawing.Point(391, 86);
            this.snapshotsCheck.Name = "snapshotsCheck";
            this.snapshotsCheck.Size = new System.Drawing.Size(76, 17);
            this.snapshotsCheck.TabIndex = 3;
            this.snapshotsCheck.Text = "Snapshots";
            this.snapshotsCheck.UseVisualStyleBackColor = true;
            this.snapshotsCheck.CheckedChanged += new System.EventHandler(this.snapshotsCheck_CheckedChanged);
            // 
            // betasCheck
            // 
            this.betasCheck.AutoSize = true;
            this.betasCheck.Location = new System.Drawing.Point(391, 109);
            this.betasCheck.Name = "betasCheck";
            this.betasCheck.Size = new System.Drawing.Size(53, 17);
            this.betasCheck.TabIndex = 5;
            this.betasCheck.Text = "Betas";
            this.betasCheck.UseVisualStyleBackColor = true;
            this.betasCheck.CheckedChanged += new System.EventHandler(this.betasCheck_CheckedChanged);
            // 
            // alphasCheck
            // 
            this.alphasCheck.AutoSize = true;
            this.alphasCheck.Location = new System.Drawing.Point(391, 132);
            this.alphasCheck.Name = "alphasCheck";
            this.alphasCheck.Size = new System.Drawing.Size(58, 17);
            this.alphasCheck.TabIndex = 6;
            this.alphasCheck.Text = "Alphas";
            this.alphasCheck.UseVisualStyleBackColor = true;
            this.alphasCheck.CheckedChanged += new System.EventHandler(this.alphasCheck_CheckedChanged);
            // 
            // loaderLabel
            // 
            this.loaderLabel.AutoSize = true;
            this.loaderLabel.Location = new System.Drawing.Point(9, 294);
            this.loaderLabel.Name = "loaderLabel";
            this.loaderLabel.Size = new System.Drawing.Size(64, 13);
            this.loaderLabel.TabIndex = 8;
            this.loaderLabel.Text = "Mod Loader";
            // 
            // noLoader
            // 
            this.noLoader.AutoSize = true;
            this.noLoader.Checked = true;
            this.noLoader.Location = new System.Drawing.Point(79, 292);
            this.noLoader.Name = "noLoader";
            this.noLoader.Size = new System.Drawing.Size(51, 17);
            this.noLoader.TabIndex = 13;
            this.noLoader.TabStop = true;
            this.noLoader.Text = "None";
            this.noLoader.UseVisualStyleBackColor = true;
            // 
            // forgeLoader
            // 
            this.forgeLoader.AutoSize = true;
            this.forgeLoader.Location = new System.Drawing.Point(134, 292);
            this.forgeLoader.Name = "forgeLoader";
            this.forgeLoader.Size = new System.Drawing.Size(52, 17);
            this.forgeLoader.TabIndex = 14;
            this.forgeLoader.Text = "Forge";
            this.forgeLoader.UseVisualStyleBackColor = true;
            this.forgeLoader.CheckedChanged += new System.EventHandler(this.forgeLoader_CheckedChanged);
            // 
            // fabricLoader
            // 
            this.fabricLoader.AutoSize = true;
            this.fabricLoader.Enabled = false;
            this.fabricLoader.Location = new System.Drawing.Point(192, 292);
            this.fabricLoader.Name = "fabricLoader";
            this.fabricLoader.Size = new System.Drawing.Size(54, 17);
            this.fabricLoader.TabIndex = 15;
            this.fabricLoader.Text = "Fabric";
            this.fabricLoader.UseVisualStyleBackColor = true;
            this.fabricLoader.CheckedChanged += new System.EventHandler(this.fabricLoader_CheckedChanged);
            // 
            // liteLoader
            // 
            this.liteLoader.AutoSize = true;
            this.liteLoader.Enabled = false;
            this.liteLoader.Location = new System.Drawing.Point(252, 292);
            this.liteLoader.Name = "liteLoader";
            this.liteLoader.Size = new System.Drawing.Size(78, 17);
            this.liteLoader.TabIndex = 16;
            this.liteLoader.Text = "Lite Loader";
            this.liteLoader.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 18;
            this.nameLabel.Text = "Name:";
            // 
            // instanceName
            // 
            this.instanceName.Location = new System.Drawing.Point(56, 13);
            this.instanceName.Name = "instanceName";
            this.instanceName.Size = new System.Drawing.Size(314, 20);
            this.instanceName.TabIndex = 19;
            // 
            // createInstance
            // 
            this.createInstance.Location = new System.Drawing.Point(391, 317);
            this.createInstance.Name = "createInstance";
            this.createInstance.Size = new System.Drawing.Size(75, 23);
            this.createInstance.TabIndex = 20;
            this.createInstance.Text = "Create";
            this.createInstance.UseVisualStyleBackColor = true;
            this.createInstance.Click += new System.EventHandler(this.createInstance_Click);
            // 
            // loaderVersionLabel
            // 
            this.loaderVersionLabel.AutoSize = true;
            this.loaderVersionLabel.Location = new System.Drawing.Point(9, 322);
            this.loaderVersionLabel.Name = "loaderVersionLabel";
            this.loaderVersionLabel.Size = new System.Drawing.Size(81, 13);
            this.loaderVersionLabel.TabIndex = 21;
            this.loaderVersionLabel.Text = "Loader Version:";
            // 
            // loaderDropdown
            // 
            this.loaderDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loaderDropdown.FormattingEnabled = true;
            this.loaderDropdown.Location = new System.Drawing.Point(96, 319);
            this.loaderDropdown.Name = "loaderDropdown";
            this.loaderDropdown.Size = new System.Drawing.Size(274, 21);
            this.loaderDropdown.TabIndex = 22;
            // 
            // CreateVanillaInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 351);
            this.Controls.Add(this.loaderDropdown);
            this.Controls.Add(this.loaderVersionLabel);
            this.Controls.Add(this.createInstance);
            this.Controls.Add(this.instanceName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.liteLoader);
            this.Controls.Add(this.fabricLoader);
            this.Controls.Add(this.forgeLoader);
            this.Controls.Add(this.noLoader);
            this.Controls.Add(this.loaderLabel);
            this.Controls.Add(this.alphasCheck);
            this.Controls.Add(this.betasCheck);
            this.Controls.Add(this.snapshotsCheck);
            this.Controls.Add(this.releasesCheck);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.versionsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateVanillaInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Instance";
            this.Load += new System.EventHandler(this.CreateVanillaInstance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView versionsList;
        private System.Windows.Forms.ColumnHeader mcVer;
        private System.Windows.Forms.ColumnHeader releaseDate;
        private System.Windows.Forms.ColumnHeader releaseType;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.CheckBox releasesCheck;
        private System.Windows.Forms.CheckBox snapshotsCheck;
        private System.Windows.Forms.CheckBox betasCheck;
        private System.Windows.Forms.CheckBox alphasCheck;
        private System.Windows.Forms.Label loaderLabel;
        private System.Windows.Forms.RadioButton noLoader;
        private System.Windows.Forms.RadioButton forgeLoader;
        private System.Windows.Forms.RadioButton fabricLoader;
        private System.Windows.Forms.RadioButton liteLoader;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox instanceName;
        private System.Windows.Forms.Button createInstance;
        private System.Windows.Forms.Label loaderVersionLabel;
        private System.Windows.Forms.ComboBox loaderDropdown;
    }
}