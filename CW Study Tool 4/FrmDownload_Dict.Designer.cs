namespace CW_Study_Tool_4
{
    partial class FrmDownload_Dict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownload_Dict));
            this.progress = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.progress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progress.Location = new System.Drawing.Point(11, 112);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(844, 56);
            this.progress.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.progress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(11, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "Downloading The Concise Oxford English-Chinese Dictionary. It may take a minute o" +
    "r just a few second (the time depends on your physical bandwidth). You can cance" +
    "l it in any moment.";
            // 
            // lbProgress
            // 
            this.lbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbProgress.Location = new System.Drawing.Point(11, 8);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(844, 101);
            this.lbProgress.TabIndex = 2;
            this.lbProgress.Text = "0 %";
            this.lbProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmDownload_Dict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(867, 299);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(893, 370);
            this.Name = "FrmDownload_Dict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Dictionary";
            this.Load += new System.EventHandler(this.FrmDownload_Dict_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProgress;
    }
}