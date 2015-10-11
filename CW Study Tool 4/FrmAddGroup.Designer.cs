namespace CW_Study_Tool_4
{
    partial class FrmAddGroup
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
            this.tbGroup.Location = new System.Drawing.Point(12, 12);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.PreventEnterBeep = true;
            this.tbGroup.Size = new System.Drawing.Size(783, 67);
            this.tbGroup.TabIndex = 0;
            this.tbGroup.TextChanged += new System.EventHandler(this.tbGroup_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(539, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 79);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "";
            this.btnAdd.SymbolSize = 15F;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = " Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbError
            // 
            this.lbError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbError.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbError.ForeColor = System.Drawing.Color.DarkRed;
            this.lbError.Location = new System.Drawing.Point(12, 94);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(521, 61);
            this.lbError.TabIndex = 2;
            // 
            // FrmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(807, 176);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbGroup);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(605, 246);
            this.Name = "FrmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool 4 - Add Group";
            this.Load += new System.EventHandler(this.FrmAddGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbGroup;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private System.Windows.Forms.Label lbError;
    }
}