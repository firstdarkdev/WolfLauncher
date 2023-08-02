namespace WolfLauncher.gui.launcher
{
    partial class InstallerForm
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
            this.downloadLabel = new System.Windows.Forms.Label();
            this.dlProgressbar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoEllipsis = true;
            this.downloadLabel.Location = new System.Drawing.Point(9, 9);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(373, 20);
            this.downloadLabel.TabIndex = 1;
            this.downloadLabel.Text = "Downloading 0/0 files";
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlProgressbar
            // 
            this.dlProgressbar.Location = new System.Drawing.Point(12, 32);
            this.dlProgressbar.Name = "dlProgressbar";
            this.dlProgressbar.Size = new System.Drawing.Size(370, 23);
            this.dlProgressbar.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 70);
            this.Controls.Add(this.dlProgressbar);
            this.Controls.Add(this.downloadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Installing Instance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstallerForm_FormClosing);
            this.Load += new System.EventHandler(this.InstallerForm_Load);
            this.Shown += new System.EventHandler(this.InstallerForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.ProgressBar dlProgressbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}