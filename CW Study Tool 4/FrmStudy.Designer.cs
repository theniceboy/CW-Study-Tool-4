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
            this.btnWordList = new DevComponents.DotNetBar.ButtonX();
            this.ShowTraslation = new DevComponents.DotNetBar.ButtonX();
            this.btnBad = new DevComponents.DotNetBar.ButtonX();
            this.btnGood = new DevComponents.DotNetBar.ButtonX();
            this.btnPrevious = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.tbTrans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sbUseShortcut = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplay
            // 
            this.btnReplay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnReplay, "btnReplay");
            this.btnReplay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReplay.FocusCuesEnabled = false;
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReplay.Symbol = "57424";
            this.btnReplay.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnReplay.SymbolSize = 12F;
            this.btnReplay.TextColor = System.Drawing.Color.Black;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnWordList
            // 
            this.btnWordList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnWordList, "btnWordList");
            this.btnWordList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWordList.FocusCuesEnabled = false;
            this.btnWordList.Name = "btnWordList";
            this.btnWordList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWordList.Symbol = "57921";
            this.btnWordList.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnWordList.SymbolSize = 12F;
            this.btnWordList.TextColor = System.Drawing.Color.Black;
            this.btnWordList.Click += new System.EventHandler(this.btnWordList_Click);
            // 
            // ShowTraslation
            // 
            this.ShowTraslation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.ShowTraslation, "ShowTraslation");
            this.ShowTraslation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ShowTraslation.FocusCuesEnabled = false;
            this.ShowTraslation.Name = "ShowTraslation";
            this.ShowTraslation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ShowTraslation.Symbol = "";
            this.ShowTraslation.SymbolSize = 12F;
            this.ShowTraslation.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowTraslation.Click += new System.EventHandler(this.ShowTraslation_Click);
            // 
            // btnBad
            // 
            this.btnBad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnBad, "btnBad");
            this.btnBad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBad.FocusCuesEnabled = false;
            this.btnBad.Name = "btnBad";
            this.btnBad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBad.Symbol = "57676";
            this.btnBad.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnBad.SymbolSize = 12F;
            this.btnBad.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // btnGood
            // 
            this.btnGood.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnGood, "btnGood");
            this.btnGood.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGood.FocusCuesEnabled = false;
            this.btnGood.Name = "btnGood";
            this.btnGood.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGood.Symbol = "58826";
            this.btnGood.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnGood.SymbolSize = 12F;
            this.btnGood.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrevious.FocusCuesEnabled = false;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrevious.Symbol = "58820";
            this.btnPrevious.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnPrevious.SymbolSize = 12F;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.FocusCuesEnabled = false;
            this.btnNext.Name = "btnNext";
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.Symbol = "58824";
            this.btnNext.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnNext.SymbolSize = 12F;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbTrans
            // 
            resources.ApplyResources(this.tbTrans, "tbTrans");
            this.tbTrans.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbTrans.Border.Class = "TextBoxBorder";
            this.tbTrans.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTrans.DisabledBackColor = System.Drawing.Color.White;
            this.tbTrans.ForeColor = System.Drawing.Color.Black;
            this.tbTrans.Name = "tbTrans";
            this.tbTrans.PreventEnterBeep = true;
            this.tbTrans.WatermarkColor = System.Drawing.Color.LightGray;
            // 
            // tbWord
            // 
            resources.ApplyResources(this.tbWord, "tbWord");
            this.tbWord.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbWord.Border.Class = "TextBoxBorder";
            this.tbWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWord.DisabledBackColor = System.Drawing.Color.White;
            this.tbWord.ForeColor = System.Drawing.Color.Black;
            this.tbWord.Name = "tbWord";
            this.tbWord.PreventEnterBeep = true;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2016;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.sbUseShortcut);
            this.pnMain.Controls.Add(this.Player);
            this.pnMain.Controls.Add(this.buttonX1);
            this.pnMain.Controls.Add(this.btnReplay);
            this.pnMain.Controls.Add(this.btnWordList);
            this.pnMain.Controls.Add(this.ShowTraslation);
            this.pnMain.Controls.Add(this.btnNext);
            this.pnMain.Controls.Add(this.btnBad);
            this.pnMain.Controls.Add(this.btnPrevious);
            this.pnMain.Controls.Add(this.btnGood);
            this.pnMain.Controls.Add(this.tbWord);
            this.pnMain.Controls.Add(this.tbTrans);
            resources.ApplyResources(this.pnMain, "pnMain");
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Name = "pnMain";
            this.pnMain.BackColorChanged += new System.EventHandler(this.pnMain_BackColorChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // sbUseShortcut
            // 
            resources.ApplyResources(this.sbUseShortcut, "sbUseShortcut");
            this.sbUseShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.sbUseShortcut.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sbUseShortcut.ForeColor = System.Drawing.Color.Black;
            this.sbUseShortcut.Name = "sbUseShortcut";
            this.sbUseShortcut.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sbUseShortcut.Value = true;
            this.sbUseShortcut.ValueObject = "Y";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Player, "Player");
            this.Player.ForeColor = System.Drawing.Color.Black;
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.buttonX1, "buttonX1");
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.FocusCuesEnabled = false;
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "57931";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.SymbolSize = 12F;
            // 
            // FrmStudy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmStudy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStudy_FormClosed);
            this.Load += new System.EventHandler(this.FrmStudy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKeyDown);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnReplay;
        private DevComponents.DotNetBar.ButtonX btnWordList;
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
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.SwitchButton sbUseShortcut;
    }
}