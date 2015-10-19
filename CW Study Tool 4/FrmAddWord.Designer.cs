namespace CW_Study_Tool_4
{
    partial class FrmAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWord));
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.tbTrans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnHelp = new DevComponents.DotNetBar.ButtonX();
            this.lbError = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.FocusCuesEnabled = false;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.Location = new System.Drawing.Point(0, 679);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(196, 74);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.Symbol = "57676";
            this.btnClear.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnClear.SymbolSize = 13F;
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = " Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Enabled = false;
            this.btnAdd.FocusCuesEnabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(958, 679);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 74);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "58826";
            this.btnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAdd.SymbolSize = 13F;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = " Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTrans
            // 
            this.tbTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTrans.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTrans.Border.Class = "TextBoxBorder";
            this.tbTrans.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTrans.DisabledBackColor = System.Drawing.Color.White;
            this.tbTrans.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbTrans.ForeColor = System.Drawing.Color.Black;
            this.tbTrans.Location = new System.Drawing.Point(0, 139);
            this.tbTrans.MaxLength = 2147483647;
            this.tbTrans.Multiline = true;
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.PreventEnterBeep = true;
            this.tbTrans.Size = new System.Drawing.Size(1154, 534);
            this.tbTrans.TabIndex = 8;
            this.tbTrans.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.tbTrans.WatermarkText = "The translation of the new word (optional), press Ctrl+Enter to add a new word, o" +
    "r just click the \"Add button\"";
            this.tbTrans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            // 
            // tbWord
            // 
            this.tbWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWord.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbWord.Border.Class = "TextBoxBorder";
            this.tbWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWord.DisabledBackColor = System.Drawing.Color.White;
            this.tbWord.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Location = new System.Drawing.Point(0, 12);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(1154, 121);
            this.tbWord.TabIndex = 7;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWord.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.tbWord.WatermarkText = "New Word (Needed)";
            this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
            this.tbWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            // 
            // btnHelp
            // 
            this.btnHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHelp.FocusCuesEnabled = false;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHelp.Location = new System.Drawing.Point(202, 679);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(196, 74);
            this.btnHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHelp.Symbol = "";
            this.btnHelp.SymbolSize = 12F;
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = " Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbError
            // 
            this.lbError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbError.ForeColor = System.Drawing.Color.Black;
            this.lbError.Location = new System.Drawing.Point(404, 691);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(548, 54);
            this.lbError.TabIndex = 12;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.lbError);
            this.pnMain.Controls.Add(this.tbWord);
            this.pnMain.Controls.Add(this.btnHelp);
            this.pnMain.Controls.Add(this.tbTrans);
            this.pnMain.Controls.Add(this.btnClear);
            this.pnMain.Controls.Add(this.btnAdd);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1157, 756);
            this.pnMain.TabIndex = 13;
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1157, 756);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(845, 465);
            this.Name = "FrmAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool - Add Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddWord_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddWord_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTrans;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWord;
        private DevComponents.DotNetBar.ButtonX btnHelp;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel pnMain;
    }
}