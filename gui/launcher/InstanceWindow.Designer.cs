namespace WolfLauncher.gui.launcher
{
    partial class InstanceWindow
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
            this.logTab = new System.Windows.Forms.TabControl();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logContainer = new System.Windows.Forms.Panel();
            this.logWindow = new System.Windows.Forms.RichTextBox();
            this.logPanelBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.launchBtn = new System.Windows.Forms.Button();
            this.launchOfflineBtn = new System.Windows.Forms.Button();
            this.demoBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.copyLog = new System.Windows.Forms.Button();
            this.uploadLog = new System.Windows.Forms.Button();
            this.clearLog = new System.Windows.Forms.Button();
            this.wrapLines = new System.Windows.Forms.CheckBox();
            this.updateLog = new System.Windows.Forms.CheckBox();
            this.logTab.SuspendLayout();
            this.logPage.SuspendLayout();
            this.logContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logPage);
            this.logTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTab.Location = new System.Drawing.Point(0, 0);
            this.logTab.Name = "logTab";
            this.logTab.SelectedIndex = 0;
            this.logTab.Size = new System.Drawing.Size(800, 450);
            this.logTab.TabIndex = 0;
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logContainer);
            this.logPage.Controls.Add(this.panel1);
            this.logPage.Controls.Add(this.topPanel);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(792, 424);
            this.logPage.TabIndex = 0;
            this.logPage.Text = "Minecraft Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logContainer
            // 
            this.logContainer.Controls.Add(this.logWindow);
            this.logContainer.Controls.Add(this.logPanelBottom);
            this.logContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logContainer.Location = new System.Drawing.Point(3, 38);
            this.logContainer.Name = "logContainer";
            this.logContainer.Size = new System.Drawing.Size(786, 351);
            this.logContainer.TabIndex = 2;
            // 
            // logWindow
            // 
            this.logWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logWindow.Location = new System.Drawing.Point(0, 0);
            this.logWindow.Name = "logWindow";
            this.logWindow.ReadOnly = true;
            this.logWindow.Size = new System.Drawing.Size(786, 319);
            this.logWindow.TabIndex = 1;
            this.logWindow.Text = "";
            this.logWindow.WordWrap = false;
            // 
            // logPanelBottom
            // 
            this.logPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logPanelBottom.Location = new System.Drawing.Point(0, 319);
            this.logPanelBottom.Name = "logPanelBottom";
            this.logPanelBottom.Size = new System.Drawing.Size(786, 32);
            this.logPanelBottom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.launchBtn);
            this.panel1.Controls.Add(this.launchOfflineBtn);
            this.panel1.Controls.Add(this.demoBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 32);
            this.panel1.TabIndex = 1;
            // 
            // launchBtn
            // 
            this.launchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchBtn.Location = new System.Drawing.Point(346, 5);
            this.launchBtn.Name = "launchBtn";
            this.launchBtn.Size = new System.Drawing.Size(114, 23);
            this.launchBtn.TabIndex = 5;
            this.launchBtn.Text = "Launch";
            this.launchBtn.UseVisualStyleBackColor = true;
            this.launchBtn.Click += new System.EventHandler(this.launchBtn_Click);
            // 
            // launchOfflineBtn
            // 
            this.launchOfflineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchOfflineBtn.Enabled = false;
            this.launchOfflineBtn.Location = new System.Drawing.Point(466, 5);
            this.launchOfflineBtn.Name = "launchOfflineBtn";
            this.launchOfflineBtn.Size = new System.Drawing.Size(114, 23);
            this.launchOfflineBtn.TabIndex = 4;
            this.launchOfflineBtn.Text = "Launch Offline";
            this.launchOfflineBtn.UseVisualStyleBackColor = true;
            // 
            // demoBtn
            // 
            this.demoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.demoBtn.Enabled = false;
            this.demoBtn.Location = new System.Drawing.Point(586, 5);
            this.demoBtn.Name = "demoBtn";
            this.demoBtn.Size = new System.Drawing.Size(114, 23);
            this.demoBtn.TabIndex = 3;
            this.demoBtn.Text = "Launch Demo";
            this.demoBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.Location = new System.Drawing.Point(706, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.copyLog);
            this.topPanel.Controls.Add(this.uploadLog);
            this.topPanel.Controls.Add(this.clearLog);
            this.topPanel.Controls.Add(this.wrapLines);
            this.topPanel.Controls.Add(this.updateLog);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(786, 35);
            this.topPanel.TabIndex = 0;
            // 
            // copyLog
            // 
            this.copyLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyLog.Enabled = false;
            this.copyLog.Location = new System.Drawing.Point(544, 4);
            this.copyLog.Name = "copyLog";
            this.copyLog.Size = new System.Drawing.Size(75, 23);
            this.copyLog.TabIndex = 4;
            this.copyLog.Text = "Copy Log";
            this.copyLog.UseVisualStyleBackColor = true;
            // 
            // uploadLog
            // 
            this.uploadLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadLog.Enabled = false;
            this.uploadLog.Location = new System.Drawing.Point(625, 4);
            this.uploadLog.Name = "uploadLog";
            this.uploadLog.Size = new System.Drawing.Size(75, 23);
            this.uploadLog.TabIndex = 3;
            this.uploadLog.Text = "Upload Log";
            this.uploadLog.UseVisualStyleBackColor = true;
            // 
            // clearLog
            // 
            this.clearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearLog.Location = new System.Drawing.Point(706, 4);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(75, 23);
            this.clearLog.TabIndex = 1;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // wrapLines
            // 
            this.wrapLines.AutoSize = true;
            this.wrapLines.Checked = true;
            this.wrapLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wrapLines.Location = new System.Drawing.Point(112, 8);
            this.wrapLines.Name = "wrapLines";
            this.wrapLines.Size = new System.Drawing.Size(80, 17);
            this.wrapLines.TabIndex = 2;
            this.wrapLines.Text = "Wrap Lines";
            this.wrapLines.UseVisualStyleBackColor = true;
            this.wrapLines.CheckedChanged += new System.EventHandler(this.wrapLines_CheckedChanged);
            // 
            // updateLog
            // 
            this.updateLog.AutoSize = true;
            this.updateLog.Checked = true;
            this.updateLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateLog.Location = new System.Drawing.Point(9, 8);
            this.updateLog.Name = "updateLog";
            this.updateLog.Size = new System.Drawing.Size(97, 17);
            this.updateLog.TabIndex = 1;
            this.updateLog.Text = "Keep Updating";
            this.updateLog.UseVisualStyleBackColor = true;
            this.updateLog.CheckedChanged += new System.EventHandler(this.updateLog_CheckedChanged);
            // 
            // InstanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logTab);
            this.Name = "InstanceWindow";
            this.Text = "InstanceWindow";
            this.Load += new System.EventHandler(this.InstanceWindow_Load);
            this.logTab.ResumeLayout(false);
            this.logPage.ResumeLayout(false);
            this.logContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl logTab;
        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.CheckBox updateLog;
        private System.Windows.Forms.CheckBox wrapLines;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.Button uploadLog;
        private System.Windows.Forms.Button copyLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button demoBtn;
        private System.Windows.Forms.Button launchOfflineBtn;
        private System.Windows.Forms.Button launchBtn;
        private System.Windows.Forms.Panel logContainer;
        private System.Windows.Forms.Panel logPanelBottom;
        private System.Windows.Forms.RichTextBox logWindow;
    }
}