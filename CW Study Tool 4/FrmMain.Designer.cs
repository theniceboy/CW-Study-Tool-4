namespace CW_Study_Tool_4
{
    partial class FrmMain
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pnWords = new System.Windows.Forms.Panel();
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddWord = new DevComponents.DotNetBar.ButtonX();
            this.lvGroups = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.cGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonX();
            this.btnExport = new DevComponents.DotNetBar.ButtonX();
            this.tbTrans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnWords.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // pnWords
            // 
            this.pnWords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnWords.Controls.Add(this.lvWords);
            this.pnWords.ForeColor = System.Drawing.Color.Black;
            this.pnWords.Location = new System.Drawing.Point(341, 3);
            this.pnWords.Name = "pnWords";
            this.pnWords.Size = new System.Drawing.Size(334, 710);
            this.pnWords.TabIndex = 10;
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
            this.columnHeader1});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.FullRowSelect = true;
            this.lvWords.Location = new System.Drawing.Point(-2, 61);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size(336, 649);
            this.lvWords.TabIndex = 5;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.SelectedIndexChanged += new System.EventHandler(this.lvWords_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Words";
            this.columnHeader1.Width = 326;
            // 
            // btnAddWord
            // 
            this.btnAddWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWord.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddWord.Enabled = false;
            this.btnAddWord.FocusCuesEnabled = false;
            this.btnAddWord.Location = new System.Drawing.Point(341, 3);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(334, 50);
            this.btnAddWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddWord.Symbol = "";
            this.btnAddWord.SymbolSize = 10F;
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = " Add Words";
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // lvGroups
            // 
            this.lvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvGroups.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvGroups.Border.Class = "ListViewBorder";
            this.lvGroups.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cGroups});
            this.lvGroups.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvGroups.ForeColor = System.Drawing.Color.Black;
            this.lvGroups.FullRowSelect = true;
            this.lvGroups.Location = new System.Drawing.Point(1, 65);
            this.lvGroups.MultiSelect = false;
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(334, 648);
            this.lvGroups.TabIndex = 9;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            this.lvGroups.SelectedIndexChanged += new System.EventHandler(this.lvGroups_SelectedIndexChanged);
            // 
            // cGroups
            // 
            this.cGroups.Text = "Groups";
            this.cGroups.Width = 326;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnAddGroup.FocusCuesEnabled = false;
            this.btnAddGroup.Location = new System.Drawing.Point(0, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(164, 50);
            this.btnAddGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGroup.Symbol = "";
            this.btnAddGroup.SymbolSize = 10F;
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = " New Group";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnExport
            // 
            this.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.btnExport.Enabled = false;
            this.btnExport.FocusCuesEnabled = false;
            this.btnExport.Location = new System.Drawing.Point(169, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(164, 50);
            this.btnExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExport.Symbol = "";
            this.btnExport.SymbolSize = 10F;
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = " Export";
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
            this.tbTrans.Location = new System.Drawing.Point(681, 157);
            this.tbTrans.MaxLength = 2147483647;
            this.tbTrans.Multiline = true;
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.PreventEnterBeep = true;
            this.tbTrans.Size = new System.Drawing.Size(683, 556);
            this.tbTrans.TabIndex = 13;
            this.tbTrans.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.tbTrans.WatermarkText = "The translation of the new word (optional)";
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
            this.tbWord.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Location = new System.Drawing.Point(681, 65);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(683, 86);
            this.tbWord.TabIndex = 12;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWord.WatermarkColor = System.Drawing.Color.Gainsboro;
            this.tbWord.WatermarkText = "Word(Needed)";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.btnAddWord);
            this.pnMain.Controls.Add(this.tbTrans);
            this.pnMain.Controls.Add(this.btnAddGroup);
            this.pnMain.Controls.Add(this.tbWord);
            this.pnMain.Controls.Add(this.lvGroups);
            this.pnMain.Controls.Add(this.btnExport);
            this.pnMain.Controls.Add(this.pnWords);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1367, 716);
            this.pnMain.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1367, 716);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool 4";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnWords.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel pnWords;
        private DevComponents.DotNetBar.Controls.ListViewEx lvWords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvGroups;
        private System.Windows.Forms.ColumnHeader cGroups;
        private DevComponents.DotNetBar.ButtonX btnAddGroup;
        private DevComponents.DotNetBar.ButtonX btnExport;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTrans;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWord;
        private DevComponents.DotNetBar.ButtonX btnAddWord;
        private System.Windows.Forms.Panel pnMain;
    }
}