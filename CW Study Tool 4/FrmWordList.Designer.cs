namespace CW_Study_Tool_4
{
    partial class FrmWordList
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
            System.Windows.Forms.ColumnHeader chWord;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWordList));
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnBad = new DevComponents.DotNetBar.ButtonX();
            this.btnGood = new DevComponents.DotNetBar.ButtonX();
            chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chWord
            // 
            chWord.Text = "Words";
            chWord.Width = 589;
            // 
            // lvWords
            // 
            this.lvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWords.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvWords.Border.Class = "ListViewBorder";
            this.lvWords.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            chWord});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.FullRowSelect = true;
            this.lvWords.GridLines = true;
            this.lvWords.Location = new System.Drawing.Point(0, 0);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.ShowItemToolTips = true;
            this.lvWords.Size = new System.Drawing.Size(592, 768);
            this.lvWords.TabIndex = 0;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.SelectedIndexChanged += new System.EventHandler(this.lvWords_SelectedIndexChanged);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.btnBad);
            this.pnMain.Controls.Add(this.btnGood);
            this.pnMain.Controls.Add(this.lvWords);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(595, 841);
            this.pnMain.TabIndex = 1;
            // 
            // btnBad
            // 
            this.btnBad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBad.FocusCuesEnabled = false;
            this.btnBad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBad.Location = new System.Drawing.Point(113, 774);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(184, 64);
            this.btnBad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBad.Symbol = "57676";
            this.btnBad.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnBad.SymbolSize = 12F;
            this.btnBad.TabIndex = 10;
            this.btnBad.Text = " Forgot\r";
            this.btnBad.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBad.Tooltip = "If you forgot this word, click this button";
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // btnGood
            // 
            this.btnGood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGood.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGood.FocusCuesEnabled = false;
            this.btnGood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGood.Location = new System.Drawing.Point(303, 774);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(184, 64);
            this.btnGood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGood.Symbol = "58826";
            this.btnGood.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnGood.SymbolSize = 12F;
            this.btnGood.TabIndex = 11;
            this.btnGood.Text = " Remember\r";
            this.btnGood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGood.Tooltip = "If you still remember this word, click on this button";
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // FrmWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(595, 841);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word List";
            this.Load += new System.EventHandler(this.FrmWordList_Load);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lvWords;
        private System.Windows.Forms.Panel pnMain;
        private DevComponents.DotNetBar.ButtonX btnBad;
        private DevComponents.DotNetBar.ButtonX btnGood;
    }
}