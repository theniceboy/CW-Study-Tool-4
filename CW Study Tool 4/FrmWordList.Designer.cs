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
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvWords
            // 
            this.lvWords.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.lvWords.Border.Class = "ListViewBorder";
            this.lvWords.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            chWord});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.FullRowSelect = true;
            this.lvWords.GridLines = true;
            this.lvWords.Location = new System.Drawing.Point(0, 0);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.ShowItemToolTips = true;
            this.lvWords.Size = new System.Drawing.Size(766, 838);
            this.lvWords.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvWords.TabIndex = 0;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.SelectedIndexChanged += new System.EventHandler(this.lvWords_SelectedIndexChanged);
            // 
            // chWord
            // 
            chWord.Text = "Words";
            chWord.Width = 703;
            // 
            // FrmWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(766, 838);
            this.Controls.Add(this.lvWords);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmWordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word List";
            this.Load += new System.EventHandler(this.FrmWordList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lvWords;
    }
}