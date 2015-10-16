namespace CW_Study_Tool_4
{
    partial class FrmStudy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudy));
            this.btnReplay = new DevComponents.DotNetBar.ButtonX();
            this.Setting = new DevComponents.DotNetBar.ButtonX();
            this.ShowTraslation = new DevComponents.DotNetBar.ButtonX();
            this.btnBad = new DevComponents.DotNetBar.ButtonX();
            this.btnGood = new DevComponents.DotNetBar.ButtonX();
            this.btnPrevious = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.tbTrans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplay
            // 
            this.btnReplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReplay.FocusCuesEnabled = false;
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReplay.Location = new System.Drawing.Point(319, 697);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(144, 79);
            this.btnReplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReplay.Symbol = "57424";
            this.btnReplay.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnReplay.SymbolSize = 12F;
            this.btnReplay.TabIndex = 5;
            this.btnReplay.Text = " Replay";
            this.btnReplay.TextColor = System.Drawing.Color.Black;
            this.btnReplay.Tooltip = "Let your computer read this word";
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // Setting
            // 
            this.Setting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Setting.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Setting.FocusCuesEnabled = false;
            this.Setting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Setting.Location = new System.Drawing.Point(113, 697);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(200, 79);
            this.Setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Setting.Symbol = "57921";
            this.Setting.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.Setting.SymbolSize = 12F;
            this.Setting.TabIndex = 6;
            this.Setting.Text = " Word List";
            this.Setting.TextColor = System.Drawing.Color.Black;
            this.Setting.Tooltip = "Show all the words that you\'re now currently learning";
            // 
            // ShowTraslation
            // 
            this.ShowTraslation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ShowTraslation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowTraslation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ShowTraslation.FocusCuesEnabled = false;
            this.ShowTraslation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowTraslation.Location = new System.Drawing.Point(881, 697);
            this.ShowTraslation.Name = "ShowTraslation";
            this.ShowTraslation.Size = new System.Drawing.Size(200, 79);
            this.ShowTraslation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ShowTraslation.Symbol = "";
            this.ShowTraslation.SymbolSize = 12F;
            this.ShowTraslation.TabIndex = 7;
            this.ShowTraslation.Text = " Traslation";
            this.ShowTraslation.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowTraslation.Tooltip = "Show the translation (answer) of this word";
            this.ShowTraslation.Click += new System.EventHandler(this.ShowTraslation_Click);
            // 
            // btnBad
            // 
            this.btnBad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBad.FocusCuesEnabled = false;
            this.btnBad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBad.Location = new System.Drawing.Point(469, 697);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(200, 79);
            this.btnBad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBad.Symbol = "57676";
            this.btnBad.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnBad.SymbolSize = 12F;
            this.btnBad.TabIndex = 8;
            this.btnBad.Text = " Forgot\r\n( 0 )";
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
            this.btnGood.Location = new System.Drawing.Point(675, 697);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(200, 79);
            this.btnGood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGood.Symbol = "58826";
            this.btnGood.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnGood.SymbolSize = 12F;
            this.btnGood.TabIndex = 9;
            this.btnGood.Text = " Remember\r\n( 0 )";
            this.btnGood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGood.Tooltip = "If you still remember this word, click on this button";
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrevious.FocusCuesEnabled = false;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.Location = new System.Drawing.Point(0, 697);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(107, 79);
            this.btnPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrevious.Symbol = "58820";
            this.btnPrevious.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnPrevious.SymbolSize = 12F;
            this.btnPrevious.TabIndex = 10;
            this.btnPrevious.Tooltip = "Previous Word";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.FocusCuesEnabled = false;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.Location = new System.Drawing.Point(1087, 697);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 79);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.Symbol = "58824";
            this.btnNext.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnNext.SymbolSize = 12F;
            this.btnNext.TabIndex = 11;
            this.btnNext.Tooltip = "Next Word";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.tbTrans.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.tbTrans.ForeColor = System.Drawing.Color.Black;
            this.tbTrans.Location = new System.Drawing.Point(0, 238);
            this.tbTrans.MaxLength = 2147483647;
            this.tbTrans.Multiline = true;
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.PreventEnterBeep = true;
            this.tbTrans.Size = new System.Drawing.Size(1311, 453);
            this.tbTrans.TabIndex = 4;
            this.tbTrans.WatermarkColor = System.Drawing.Color.LightGray;
            this.tbTrans.WatermarkText = "(Click the \"Translation\" button to show the translation (answer) to this word";
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
            this.tbWord.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Location = new System.Drawing.Point(0, 12);
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            this.tbWord.Size = new System.Drawing.Size(1311, 220);
            this.tbWord.TabIndex = 3;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.Player);
            this.pnMain.Controls.Add(this.buttonX1);
            this.pnMain.Controls.Add(this.btnReplay);
            this.pnMain.Controls.Add(this.Setting);
            this.pnMain.Controls.Add(this.ShowTraslation);
            this.pnMain.Controls.Add(this.btnNext);
            this.pnMain.Controls.Add(this.btnBad);
            this.pnMain.Controls.Add(this.btnPrevious);
            this.pnMain.Controls.Add(this.btnGood);
            this.pnMain.Controls.Add(this.tbWord);
            this.pnMain.Controls.Add(this.tbTrans);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1314, 779);
            this.pnMain.TabIndex = 12;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.FocusCuesEnabled = false;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonX1.Location = new System.Drawing.Point(1202, 697);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(109, 79);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "57931";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.SymbolSize = 12F;
            this.buttonX1.TabIndex = 12;
            this.buttonX1.Tooltip = "Show the statisitics";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(608, 401);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(473, 36);
            this.Player.TabIndex = 13;
            this.Player.Visible = false;
            // 
            // FrmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 779);
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmStudy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmStudy_Load);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnReplay;
        private DevComponents.DotNetBar.ButtonX Setting;
        private DevComponents.DotNetBar.ButtonX ShowTraslation;
        private DevComponents.DotNetBar.ButtonX btnBad;
        private DevComponents.DotNetBar.ButtonX btnGood;
        private DevComponents.DotNetBar.ButtonX btnPrevious;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTrans;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWord;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel pnMain;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
    }
}