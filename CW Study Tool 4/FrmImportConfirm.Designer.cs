namespace CW_Study_Tool_4
{
    partial class FrmImportConfirm
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
            this.tbGroup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.lbError = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGroup
            // 
            this.tbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGroup.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbGroup.Border.Class = "TextBoxBorder";
            this.tbGroup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbGroup.DisabledBackColor = System.Drawing.Color.White;
            this.tbGroup.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tbGroup.ForeColor = System.Drawing.Color.Black;
            this.tbGroup.Location = new System.Drawing.Point(0, 14);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.PreventEnterBeep = true;
            this.tbGroup.Size = new System.Drawing.Size(804, 67);
            this.tbGroup.TabIndex = 0;
            this.tbGroup.TextChanged += new System.EventHandler(this.tbGroup_TextChanged);
            this.tbGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbGroup_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(530, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(274, 84);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "58826";
            this.btnAdd.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAdd.SymbolSize = 15F;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = " Import";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbError
            // 
            this.lbError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbError.ForeColor = System.Drawing.Color.Black;
            this.lbError.Location = new System.Drawing.Point(14, 104);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(510, 61);
            this.lbError.TabIndex = 2;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnMain.Controls.Add(this.lbError);
            this.pnMain.Controls.Add(this.tbGroup);
            this.pnMain.Controls.Add(this.btnAdd);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(807, 176);
            this.pnMain.TabIndex = 3;
            // 
            // FrmImportConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(807, 176);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmImportConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool 4 - Add Group";
            this.Load += new System.EventHandler(this.FrmAddGroup_Load);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbGroup;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Panel pnMain;
    }
}