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
            this.btnAddWord = new DevComponents.DotNetBar.ButtonX();
            this.lvWords = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGroups = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.cGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonX();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dbSelector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.radialMenu = new DevComponents.DotNetBar.RadialMenu();
            this.riDelete = new DevComponents.DotNetBar.RadialMenuItem();
            this.riExport = new DevComponents.DotNetBar.RadialMenuItem();
            this.riRename = new DevComponents.DotNetBar.RadialMenuItem();
            this.pnLearn = new System.Windows.Forms.Panel();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.gpOperations = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.gpStudy = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.gpExams = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.rmGroup = new DevComponents.DotNetBar.RadialMenu();
            this.pnWords.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnLearn.SuspendLayout();
            this.flpControls.SuspendLayout();
            this.gpOperations.SuspendLayout();
            this.gpStudy.SuspendLayout();
            this.gpExams.SuspendLayout();
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
            this.pnWords.Controls.Add(this.btnAddWord);
            this.pnWords.Controls.Add(this.lvWords);
            this.pnWords.ForeColor = System.Drawing.Color.Black;
            this.pnWords.Location = new System.Drawing.Point(384, 3);
            this.pnWords.Name = "pnWords";
            this.pnWords.Size = new System.Drawing.Size(376, 736);
            this.pnWords.TabIndex = 10;
            // 
            // btnAddWord
            // 
            this.btnAddWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWord.BackColor = System.Drawing.Color.White;
            this.btnAddWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddWord.Enabled = false;
            this.btnAddWord.FocusCuesEnabled = false;
            this.btnAddWord.Location = new System.Drawing.Point(0, 7);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(376, 56);
            this.btnAddWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddWord.Symbol = "57672";
            this.btnAddWord.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddWord.SymbolSize = 12F;
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = " Add Words";
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
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
            this.lvWords.Location = new System.Drawing.Point(0, 70);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.Size = new System.Drawing.Size(376, 666);
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
            this.lvGroups.Location = new System.Drawing.Point(1, 73);
            this.lvGroups.MultiSelect = false;
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(376, 666);
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
            this.btnAddGroup.BackColor = System.Drawing.Color.White;
            this.btnAddGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddGroup.FocusCuesEnabled = false;
            this.btnAddGroup.Location = new System.Drawing.Point(1, 10);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(314, 56);
            this.btnAddGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGroup.Symbol = "58298";
            this.btnAddGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddGroup.SymbolSize = 12F;
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = " New Group";
            this.btnAddGroup.Tooltip = "Add a new group to store some words. The usage of the \'groups\' is to categorize y" +
    "our words.";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnMain.Controls.Add(this.rmGroup);
            this.pnMain.Controls.Add(this.dbSelector);
            this.pnMain.Controls.Add(this.radialMenu);
            this.pnMain.Controls.Add(this.pnLearn);
            this.pnMain.Controls.Add(this.btnAddGroup);
            this.pnMain.Controls.Add(this.lvGroups);
            this.pnMain.Controls.Add(this.pnWords);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.ForeColor = System.Drawing.Color.Black;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1155, 742);
            this.pnMain.TabIndex = 14;
            // 
            // dbSelector
            // 
            this.dbSelector.DisplayMember = "Text";
            this.dbSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbSelector.ForeColor = System.Drawing.Color.Black;
            this.dbSelector.FormattingEnabled = true;
            this.dbSelector.ItemHeight = 37;
            this.dbSelector.Location = new System.Drawing.Point(769, 16);
            this.dbSelector.Name = "dbSelector";
            this.dbSelector.Size = new System.Drawing.Size(317, 43);
            this.dbSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dbSelector.TabIndex = 14;
            // 
            // radialMenu
            // 
            this.radialMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radialMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radialMenu.ForeColor = System.Drawing.Color.Black;
            this.radialMenu.Location = new System.Drawing.Point(1094, 10);
            this.radialMenu.Name = "radialMenu";
            this.radialMenu.Size = new System.Drawing.Size(56, 56);
            this.radialMenu.Symbol = "59576";
            this.radialMenu.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.radialMenu.SymbolSize = 11F;
            this.radialMenu.TabIndex = 13;
            // 
            // riDelete
            // 
            this.riDelete.Name = "riDelete";
            this.riDelete.Symbol = "57676";
            this.riDelete.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riDelete.Text = "Delete";
            this.riDelete.Tooltip = "Delete the seleted group. Warning: this operation will delete this group <b>and a" +
    "ll the words in this group</b>!";
            // 
            // riExport
            // 
            this.riExport.Name = "riExport";
            this.riExport.Symbol = "57694";
            this.riExport.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riExport.Text = "Export";
            this.riExport.Tooltip = "Export the selected group into a file that you can give to anyone else so they ca" +
    "n import into thier CW Study Tool 4 to study the word you exported";
            // 
            // riRename
            // 
            this.riRename.Name = "riRename";
            this.riRename.Symbol = "59485";
            this.riRename.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riRename.Text = "Rename";
            this.riRename.Tooltip = "Rename your group";
            // 
            // pnLearn
            // 
            this.pnLearn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLearn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnLearn.Controls.Add(this.flpControls);
            this.pnLearn.ForeColor = System.Drawing.Color.Black;
            this.pnLearn.Location = new System.Drawing.Point(766, 73);
            this.pnLearn.Name = "pnLearn";
            this.pnLearn.Size = new System.Drawing.Size(386, 666);
            this.pnLearn.TabIndex = 12;
            // 
            // flpControls
            // 
            this.flpControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.flpControls.Controls.Add(this.gpOperations);
            this.flpControls.Controls.Add(this.gpStudy);
            this.flpControls.Controls.Add(this.gpExams);
            this.flpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpControls.ForeColor = System.Drawing.Color.Black;
            this.flpControls.Location = new System.Drawing.Point(0, 0);
            this.flpControls.Name = "flpControls";
            this.flpControls.Size = new System.Drawing.Size(386, 666);
            this.flpControls.TabIndex = 12;
            // 
            // gpOperations
            // 
            this.gpOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpOperations.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpOperations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpOperations.Controls.Add(this.buttonX5);
            this.gpOperations.Controls.Add(this.buttonX6);
            this.gpOperations.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpOperations.Enabled = false;
            this.gpOperations.Location = new System.Drawing.Point(3, 3);
            this.gpOperations.Name = "gpOperations";
            this.gpOperations.Size = new System.Drawing.Size(379, 215);
            // 
            // 
            // 
            this.gpOperations.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpOperations.Style.BackColorGradientAngle = 90;
            this.gpOperations.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpOperations.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpOperations.Style.BorderBottomWidth = 1;
            this.gpOperations.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpOperations.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpOperations.Style.BorderLeftWidth = 1;
            this.gpOperations.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpOperations.Style.BorderRightWidth = 1;
            this.gpOperations.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpOperations.Style.BorderTopWidth = 1;
            this.gpOperations.Style.CornerDiameter = 4;
            this.gpOperations.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpOperations.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpOperations.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpOperations.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpOperations.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpOperations.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpOperations.TabIndex = 11;
            this.gpOperations.Text = "Operations";
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.FocusCuesEnabled = false;
            this.buttonX5.Location = new System.Drawing.Point(3, 91);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(366, 76);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.Symbol = "58829";
            this.buttonX5.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX5.SymbolSize = 15F;
            this.buttonX5.TabIndex = 8;
            this.buttonX5.Text = " Delete Word";
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.FocusCuesEnabled = false;
            this.buttonX6.Location = new System.Drawing.Point(3, 3);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(366, 81);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.Symbol = "57940";
            this.buttonX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX6.SymbolSize = 15F;
            this.buttonX6.TabIndex = 7;
            this.buttonX6.Text = " Edit Word";
            // 
            // gpStudy
            // 
            this.gpStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpStudy.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpStudy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpStudy.Controls.Add(this.buttonX2);
            this.gpStudy.Controls.Add(this.buttonX1);
            this.gpStudy.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpStudy.Enabled = false;
            this.gpStudy.Location = new System.Drawing.Point(3, 224);
            this.gpStudy.Name = "gpStudy";
            this.gpStudy.Size = new System.Drawing.Size(379, 215);
            // 
            // 
            // 
            this.gpStudy.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpStudy.Style.BackColorGradientAngle = 90;
            this.gpStudy.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpStudy.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpStudy.Style.BorderBottomWidth = 1;
            this.gpStudy.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpStudy.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpStudy.Style.BorderLeftWidth = 1;
            this.gpStudy.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpStudy.Style.BorderRightWidth = 1;
            this.gpStudy.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpStudy.Style.BorderTopWidth = 1;
            this.gpStudy.Style.CornerDiameter = 4;
            this.gpStudy.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpStudy.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpStudy.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpStudy.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpStudy.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpStudy.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpStudy.TabIndex = 9;
            this.gpStudy.Text = "Study";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.FocusCuesEnabled = false;
            this.buttonX2.Location = new System.Drawing.Point(3, 91);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(366, 76);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "58837";
            this.buttonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = " Multi-Round Study";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.FocusCuesEnabled = false;
            this.buttonX1.Location = new System.Drawing.Point(3, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(366, 81);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "57399";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = " Walkthough";
            // 
            // gpExams
            // 
            this.gpExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpExams.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpExams.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpExams.Controls.Add(this.buttonX3);
            this.gpExams.Controls.Add(this.buttonX4);
            this.gpExams.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpExams.Enabled = false;
            this.gpExams.Location = new System.Drawing.Point(3, 445);
            this.gpExams.Name = "gpExams";
            this.gpExams.Size = new System.Drawing.Size(379, 215);
            // 
            // 
            // 
            this.gpExams.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpExams.Style.BackColorGradientAngle = 90;
            this.gpExams.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpExams.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpExams.Style.BorderBottomWidth = 1;
            this.gpExams.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpExams.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpExams.Style.BorderLeftWidth = 1;
            this.gpExams.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpExams.Style.BorderRightWidth = 1;
            this.gpExams.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpExams.Style.BorderTopWidth = 1;
            this.gpExams.Style.CornerDiameter = 4;
            this.gpExams.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpExams.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpExams.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpExams.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpExams.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpExams.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpExams.TabIndex = 10;
            this.gpExams.Text = "Exams";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.FocusCuesEnabled = false;
            this.buttonX3.Location = new System.Drawing.Point(3, 91);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(366, 76);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "59511";
            this.buttonX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX3.SymbolSize = 15F;
            this.buttonX3.TabIndex = 8;
            this.buttonX3.Text = " Full Exam";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.FocusCuesEnabled = false;
            this.buttonX4.Location = new System.Drawing.Point(3, 3);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(366, 81);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "59510";
            this.buttonX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX4.SymbolSize = 15F;
            this.buttonX4.TabIndex = 7;
            this.buttonX4.Text = " Quick Exam";
            // 
            // rmGroup
            // 
            this.rmGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rmGroup.ForeColor = System.Drawing.Color.Black;
            this.rmGroup.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.riDelete,
            this.riRename,
            this.riExport});
            this.rmGroup.Location = new System.Drawing.Point(321, 10);
            this.rmGroup.Name = "rmGroup";
            this.rmGroup.Size = new System.Drawing.Size(56, 56);
            this.rmGroup.Symbol = "57377";
            this.rmGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.rmGroup.SymbolSize = 13F;
            this.rmGroup.TabIndex = 15;
            this.rmGroup.ItemClick += new System.EventHandler(this.rmGroup_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1155, 742);
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
            this.pnLearn.ResumeLayout(false);
            this.flpControls.ResumeLayout(false);
            this.gpOperations.ResumeLayout(false);
            this.gpStudy.ResumeLayout(false);
            this.gpExams.ResumeLayout(false);
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
        private DevComponents.DotNetBar.ButtonX btnAddWord;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLearn;
        private DevComponents.DotNetBar.RadialMenu radialMenu;
        private DevComponents.DotNetBar.RadialMenuItem riDelete;
        private DevComponents.DotNetBar.RadialMenuItem riExport;
        private DevComponents.DotNetBar.RadialMenuItem riRename;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private DevComponents.DotNetBar.Controls.GroupPanel gpOperations;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.Controls.GroupPanel gpStudy;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpExams;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx dbSelector;
        private DevComponents.DotNetBar.RadialMenu rmGroup;
    }
}