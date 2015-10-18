namespace CW_Study_Tool_4
{
    partial class FrmAddWord_Batch
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
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.tbWords = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dictSelector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ciNone = new DevComponents.Editors.ComboItem();
            this.ciEnglish_Chinese = new DevComponents.Editors.ComboItem();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(528, 811);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 80);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "58826";
            this.btnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAdd.SymbolSize = 13F;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = " Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbWords
            // 
            this.tbWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWords.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbWords.Border.Class = "TextBoxBorder";
            this.tbWords.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWords.DisabledBackColor = System.Drawing.Color.White;
            this.tbWords.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbWords.ForeColor = System.Drawing.Color.Black;
            this.tbWords.Location = new System.Drawing.Point(0, 12);
            this.tbWords.MaxLength = 2147483647;
            this.tbWords.Multiline = true;
            this.tbWords.Name = "tbWords";
            this.tbWords.PreventEnterBeep = true;
            this.tbWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWords.Size = new System.Drawing.Size(748, 793);
            this.tbWords.TabIndex = 8;
            this.tbWords.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.tbWords.WatermarkText = "The translation of the new word (optional), press Ctrl+Enter to add a new word, o" +
    "r just click the \"Add button\"";
            this.tbWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.dictSelector);
            this.pnMain.Controls.Add(this.tbWords);
            this.pnMain.Controls.Add(this.btnAdd);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(752, 894);
            this.pnMain.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 808);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Auto Detect Translation:";
            // 
            // dictSelector
            // 
            this.dictSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictSelector.DisplayMember = "Text";
            this.dictSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dictSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dictSelector.ForeColor = System.Drawing.Color.Black;
            this.dictSelector.FormattingEnabled = true;
            this.dictSelector.ItemHeight = 37;
            this.dictSelector.Items.AddRange(new object[] {
            this.ciNone,
            this.ciEnglish_Chinese});
            this.dictSelector.Location = new System.Drawing.Point(0, 848);
            this.dictSelector.Name = "dictSelector";
            this.dictSelector.Size = new System.Drawing.Size(522, 43);
            this.dictSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dictSelector.TabIndex = 15;
            this.dictSelector.SelectedIndexChanged += new System.EventHandler(this.dictSelector_SelectedIndexChanged);
            // 
            // ciNone
            // 
            this.ciNone.Text = "None";
            // 
            // ciEnglish_Chinese
            // 
            this.ciEnglish_Chinese.Text = "English-Chinese";
            // 
            // FrmAddWord_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(752, 894);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(560, 513);
            this.Name = "FrmAddWord_Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool - Add Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddWord_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddWord_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWords;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx dictSelector;
        private DevComponents.Editors.ComboItem ciNone;
        private DevComponents.Editors.ComboItem ciEnglish_Chinese;
    }
}