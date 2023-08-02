namespace WolfLauncher.gui.launcher
{
    partial class InstanceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceSettings));
            this.maxRamLabel = new System.Windows.Forms.Label();
            this.minRamLabel = new System.Windows.Forms.Label();
            this.maxRam = new System.Windows.Forms.NumericUpDown();
            this.minRam = new System.Windows.Forms.NumericUpDown();
            this.javaArgsLabel = new System.Windows.Forms.Label();
            this.jvmArgs = new System.Windows.Forms.TextBox();
            this.screenHeightLabel = new System.Windows.Forms.Label();
            this.screenWidthLabel = new System.Windows.Forms.Label();
            this.screenWidth = new System.Windows.Forms.TextBox();
            this.screenHeight = new System.Windows.Forms.TextBox();
            this.saveSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRam)).BeginInit();
            this.SuspendLayout();
            // 
            // maxRamLabel
            // 
            this.maxRamLabel.AutoSize = true;
            this.maxRamLabel.Location = new System.Drawing.Point(12, 9);
            this.maxRamLabel.Name = "maxRamLabel";
            this.maxRamLabel.Size = new System.Drawing.Size(80, 13);
            this.maxRamLabel.TabIndex = 0;
            this.maxRamLabel.Text = "Max Ram (MB):";
            // 
            // minRamLabel
            // 
            this.minRamLabel.AutoSize = true;
            this.minRamLabel.Location = new System.Drawing.Point(12, 37);
            this.minRamLabel.Name = "minRamLabel";
            this.minRamLabel.Size = new System.Drawing.Size(77, 13);
            this.minRamLabel.TabIndex = 1;
            this.minRamLabel.Text = "Min Ram (MB):";
            // 
            // maxRam
            // 
            this.maxRam.Increment = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.maxRam.Location = new System.Drawing.Point(106, 7);
            this.maxRam.Name = "maxRam";
            this.maxRam.Size = new System.Drawing.Size(120, 20);
            this.maxRam.TabIndex = 2;
            // 
            // minRam
            // 
            this.minRam.Increment = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.minRam.Location = new System.Drawing.Point(106, 35);
            this.minRam.Name = "minRam";
            this.minRam.Size = new System.Drawing.Size(120, 20);
            this.minRam.TabIndex = 3;
            // 
            // javaArgsLabel
            // 
            this.javaArgsLabel.AutoSize = true;
            this.javaArgsLabel.Location = new System.Drawing.Point(12, 62);
            this.javaArgsLabel.Name = "javaArgsLabel";
            this.javaArgsLabel.Size = new System.Drawing.Size(57, 13);
            this.javaArgsLabel.TabIndex = 4;
            this.javaArgsLabel.Text = "Java Args:";
            // 
            // jvmArgs
            // 
            this.jvmArgs.Location = new System.Drawing.Point(106, 61);
            this.jvmArgs.Multiline = true;
            this.jvmArgs.Name = "jvmArgs";
            this.jvmArgs.Size = new System.Drawing.Size(330, 195);
            this.jvmArgs.TabIndex = 5;
            // 
            // screenHeightLabel
            // 
            this.screenHeightLabel.AutoSize = true;
            this.screenHeightLabel.Location = new System.Drawing.Point(12, 294);
            this.screenHeightLabel.Name = "screenHeightLabel";
            this.screenHeightLabel.Size = new System.Drawing.Size(78, 13);
            this.screenHeightLabel.TabIndex = 7;
            this.screenHeightLabel.Text = "Screen Height:";
            // 
            // screenWidthLabel
            // 
            this.screenWidthLabel.AutoSize = true;
            this.screenWidthLabel.Location = new System.Drawing.Point(12, 266);
            this.screenWidthLabel.Name = "screenWidthLabel";
            this.screenWidthLabel.Size = new System.Drawing.Size(75, 13);
            this.screenWidthLabel.TabIndex = 6;
            this.screenWidthLabel.Text = "Screen Width:";
            // 
            // screenWidth
            // 
            this.screenWidth.Location = new System.Drawing.Point(106, 263);
            this.screenWidth.Name = "screenWidth";
            this.screenWidth.Size = new System.Drawing.Size(120, 20);
            this.screenWidth.TabIndex = 8;
            // 
            // screenHeight
            // 
            this.screenHeight.Location = new System.Drawing.Point(106, 291);
            this.screenHeight.Name = "screenHeight";
            this.screenHeight.Size = new System.Drawing.Size(120, 20);
            this.screenHeight.TabIndex = 9;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(361, 288);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(75, 23);
            this.saveSettings.TabIndex = 10;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // InstanceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 324);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.screenHeight);
            this.Controls.Add(this.screenWidth);
            this.Controls.Add(this.screenHeightLabel);
            this.Controls.Add(this.screenWidthLabel);
            this.Controls.Add(this.jvmArgs);
            this.Controls.Add(this.javaArgsLabel);
            this.Controls.Add(this.minRam);
            this.Controls.Add(this.maxRam);
            this.Controls.Add(this.minRamLabel);
            this.Controls.Add(this.maxRamLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstanceSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instance Settings";
            this.Load += new System.EventHandler(this.InstanceSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxRamLabel;
        private System.Windows.Forms.Label minRamLabel;
        private System.Windows.Forms.NumericUpDown maxRam;
        private System.Windows.Forms.NumericUpDown minRam;
        private System.Windows.Forms.Label javaArgsLabel;
        private System.Windows.Forms.TextBox jvmArgs;
        private System.Windows.Forms.Label screenHeightLabel;
        private System.Windows.Forms.Label screenWidthLabel;
        private System.Windows.Forms.TextBox screenWidth;
        private System.Windows.Forms.TextBox screenHeight;
        private System.Windows.Forms.Button saveSettings;
    }
}