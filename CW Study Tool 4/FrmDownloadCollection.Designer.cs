namespace CW_Study_Tool_4
{
    partial class FrmDownloadCollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownloadCollection));
            this.dbSelector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ciCET4 = new DevComponents.Editors.ComboItem();
            this.btnDownload = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // dbSelector
            // 
            this.dbSelector.DisplayMember = "Text";
            this.dbSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbSelector.ForeColor = System.Drawing.Color.Black;
            this.dbSelector.FormattingEnabled = true;
            this.dbSelector.ItemHeight = 33;
            this.dbSelector.Items.AddRange(new object[] {
            this.ciCET4});
            this.dbSelector.Location = new System.Drawing.Point(13, 13);
            this.dbSelector.Name = "dbSelector";
            this.dbSelector.Size = new System.Drawing.Size(614, 39);
            this.dbSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dbSelector.TabIndex = 15;
            // 
            // ciCET4
            // 
            this.ciCET4.Text = "China CET 4";
            // 
            // btnDownload
            // 
            this.btnDownload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDownload.FocusCuesEnabled = false;
            this.btnDownload.Location = new System.Drawing.Point(410, 58);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(217, 68);
            this.btnDownload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDownload.Symbol = "59510";
            this.btnDownload.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnDownload.SymbolSize = 15F;
            this.btnDownload.TabIndex = 16;
            this.btnDownload.Text = " Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FrmDownloadCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(640, 138);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dbSelector);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(666, 209);
            this.MinimumSize = new System.Drawing.Size(666, 209);
            this.Name = "FrmDownloadCollection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Collection";
            this.Load += new System.EventHandler(this.FrmDownloadCollection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx dbSelector;
        private DevComponents.Editors.ComboItem ciCET4;
        private DevComponents.DotNetBar.ButtonX btnDownload;
    }
}