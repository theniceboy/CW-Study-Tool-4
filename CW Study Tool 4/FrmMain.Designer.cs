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
            this.chWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGroups = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.chGroups = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddGroup = new DevComponents.DotNetBar.ButtonX();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnImport = new DevComponents.DotNetBar.ButtonX();
            this.rmGroup = new DevComponents.DotNetBar.RadialMenu();
            this.riClearStudyRecord = new DevComponents.DotNetBar.RadialMenuItem();
            this.riDelete = new DevComponents.DotNetBar.RadialMenuItem();
            this.riRename = new DevComponents.DotNetBar.RadialMenuItem();
            this.riExport = new DevComponents.DotNetBar.RadialMenuItem();
            this.dbSelector = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.rmSettings = new DevComponents.DotNetBar.RadialMenu();
            this.pnLearn = new System.Windows.Forms.Panel();
            this.flpControls = new System.Windows.Forms.FlowLayoutPanel();
            this.gpOperations = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDeleteWord = new DevComponents.DotNetBar.ButtonX();
            this.btnEditWord = new DevComponents.DotNetBar.ButtonX();
            this.gpStudy = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnMultiRoundStudy = new DevComponents.DotNetBar.ButtonX();
            this.btnWalkthough = new DevComponents.DotNetBar.ButtonX();
            this.gpExams = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFullExam = new DevComponents.DotNetBar.ButtonX();
            this.btnQuickExam = new DevComponents.DotNetBar.ButtonX();
            this.btnBatch = new DevComponents.DotNetBar.ButtonX();
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
            this.pnWords.Controls.Add(this.btnBatch);
            this.pnWords.Controls.Add(this.btnAddWord);
            this.pnWords.Controls.Add(this.lvWords);
            this.pnWords.Enabled = false;
            this.pnWords.ForeColor = System.Drawing.Color.Black;
            this.pnWords.Location = new System.Drawing.Point(384, 3);
            this.pnWords.Name = "pnWords";
            this.pnWords.Size = new System.Drawing.Size(376, 736);
            this.pnWords.TabIndex = 10;
            this.pnWords.BackColorChanged += new System.EventHandler(this.pnWords_BackColorChanged);
            // 
            // btnAddWord
            // 
            this.btnAddWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddWord.BackColor = System.Drawing.Color.White;
            this.btnAddWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddWord.FocusCuesEnabled = false;
            this.btnAddWord.Location = new System.Drawing.Point(0, 7);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(185, 56);
            this.btnAddWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddWord.Symbol = "57672";
            this.btnAddWord.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddWord.SymbolSize = 12F;
            this.btnAddWord.TabIndex = 6;
            this.btnAddWord.Text = " Word";
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
            this.chWords});
            this.lvWords.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvWords.ForeColor = System.Drawing.Color.Black;
            this.lvWords.FullRowSelect = true;
            this.lvWords.Location = new System.Drawing.Point(0, 70);
            this.lvWords.MultiSelect = false;
            this.lvWords.Name = "lvWords";
            this.lvWords.ShowItemToolTips = true;
            this.lvWords.Size = new System.Drawing.Size(376, 666);
            this.lvWords.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvWords.TabIndex = 5;
            this.lvWords.UseCompatibleStateImageBehavior = false;
            this.lvWords.View = System.Windows.Forms.View.Details;
            this.lvWords.SelectedIndexChanged += new System.EventHandler(this.lvWords_SelectedIndexChanged);
            // 
            // chWords
            // 
            this.chWords.Text = "Words";
            this.chWords.Width = 326;
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
            this.chGroups});
            this.lvGroups.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvGroups.ForeColor = System.Drawing.Color.Black;
            this.lvGroups.FullRowSelect = true;
            this.lvGroups.Location = new System.Drawing.Point(1, 73);
            this.lvGroups.MultiSelect = false;
            this.lvGroups.Name = "lvGroups";
            this.lvGroups.Size = new System.Drawing.Size(376, 666);
            this.lvGroups.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvGroups.TabIndex = 9;
            this.lvGroups.UseCompatibleStateImageBehavior = false;
            this.lvGroups.View = System.Windows.Forms.View.Details;
            this.lvGroups.SelectedIndexChanged += new System.EventHandler(this.lvGroups_SelectedIndexChanged);
            // 
            // chGroups
            // 
            this.chGroups.Text = "Groups";
            this.chGroups.Width = 326;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddGroup.BackColor = System.Drawing.Color.White;
            this.btnAddGroup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddGroup.FocusCuesEnabled = false;
            this.btnAddGroup.Location = new System.Drawing.Point(1, 10);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(154, 56);
            this.btnAddGroup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddGroup.Symbol = "58298";
            this.btnAddGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnAddGroup.SymbolSize = 12F;
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = " Group";
            this.btnAddGroup.Tooltip = "Add a new group to store some words. The usage of the \'groups\' is to categorize y" +
    "our words.";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.btnImport);
            this.pnMain.Controls.Add(this.rmGroup);
            this.pnMain.Controls.Add(this.dbSelector);
            this.pnMain.Controls.Add(this.rmSettings);
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
            this.pnMain.BackColorChanged += new System.EventHandler(this.pnMain_BackColorChanged);
            // 
            // btnImport
            // 
            this.btnImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImport.FocusCuesEnabled = false;
            this.btnImport.Location = new System.Drawing.Point(161, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(154, 56);
            this.btnImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImport.Symbol = "58052";
            this.btnImport.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnImport.SymbolSize = 12F;
            this.btnImport.TabIndex = 17;
            this.btnImport.Text = " Import";
            this.btnImport.Tooltip = "Add a new group to store some words. The usage of the \'groups\' is to categorize y" +
    "our words.";
            // 
            // rmGroup
            // 
            this.rmGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rmGroup.Diameter = 200;
            this.rmGroup.Enabled = false;
            this.rmGroup.ForeColor = System.Drawing.Color.Black;
            this.rmGroup.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.riClearStudyRecord,
            this.riDelete,
            this.riRename,
            this.riExport});
            this.rmGroup.Location = new System.Drawing.Point(321, 10);
            this.rmGroup.Name = "rmGroup";
            this.rmGroup.Size = new System.Drawing.Size(56, 56);
            this.rmGroup.Symbol = "57377";
            this.rmGroup.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.rmGroup.SymbolSize = 13F;
            this.rmGroup.TabIndex = 16;
            this.rmGroup.ItemClick += new System.EventHandler(this.rmGroup_ItemClick);
            // 
            // riClearStudyRecord
            // 
            this.riClearStudyRecord.Name = "riClearStudyRecord";
            this.riClearStudyRecord.Symbol = "58829";
            this.riClearStudyRecord.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riClearStudyRecord.Text = "Clear Records";
            this.riClearStudyRecord.Tooltip = "Empty your study record (your choice \'remember\' or \'forgot\' on each word) in this" +
    " group";
            // 
            // riDelete
            // 
            this.riDelete.Name = "riDelete";
            this.riDelete.Symbol = "58825";
            this.riDelete.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riDelete.Text = "Delete";
            this.riDelete.Tooltip = "Delete the seleted group. Warning: this operation will delete this group <b>and a" +
    "ll the words in this group</b>!";
            // 
            // riRename
            // 
            this.riRename.Name = "riRename";
            this.riRename.Symbol = "59485";
            this.riRename.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riRename.Text = "Rename";
            this.riRename.Tooltip = "Rename your group";
            // 
            // riExport
            // 
            this.riExport.Name = "riExport";
            this.riExport.Symbol = "57694";
            this.riExport.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.riExport.Text = "Export";
            this.riExport.Tooltip = "Export the selected group into a file that you can give to anyone else and they c" +
    "an import into thier CW Study Tool 4 to study the word you exported";
            // 
            // dbSelector
            // 
            this.dbSelector.DisplayMember = "Text";
            this.dbSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbSelector.ForeColor = System.Drawing.Color.Black;
            this.dbSelector.FormattingEnabled = true;
            this.dbSelector.ItemHeight = 37;
            this.dbSelector.Location = new System.Drawing.Point(770, 16);
            this.dbSelector.Name = "dbSelector";
            this.dbSelector.Size = new System.Drawing.Size(317, 43);
            this.dbSelector.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dbSelector.TabIndex = 14;
            this.dbSelector.SelectedIndexChanged += new System.EventHandler(this.dbSelector_SelectedIndexChanged);
            // 
            // rmSettings
            // 
            this.rmSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rmSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rmSettings.ForeColor = System.Drawing.Color.Black;
            this.rmSettings.Location = new System.Drawing.Point(1094, 10);
            this.rmSettings.Name = "rmSettings";
            this.rmSettings.Size = new System.Drawing.Size(56, 56);
            this.rmSettings.Symbol = "59576";
            this.rmSettings.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.rmSettings.SymbolSize = 11F;
            this.rmSettings.TabIndex = 13;
            this.rmSettings.ItemClick += new System.EventHandler(this.rmSettings_ItemClick);
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
            this.pnLearn.BackColorChanged += new System.EventHandler(this.pnLearn_BackColorChanged);
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
            this.flpControls.BackColorChanged += new System.EventHandler(this.flpControls_BackColorChanged);
            // 
            // gpOperations
            // 
            this.gpOperations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpOperations.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpOperations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpOperations.Controls.Add(this.btnDeleteWord);
            this.gpOperations.Controls.Add(this.btnEditWord);
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
            // btnDeleteWord
            // 
            this.btnDeleteWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteWord.FocusCuesEnabled = false;
            this.btnDeleteWord.Location = new System.Drawing.Point(3, 91);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(366, 76);
            this.btnDeleteWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteWord.Symbol = "58829";
            this.btnDeleteWord.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnDeleteWord.SymbolSize = 15F;
            this.btnDeleteWord.TabIndex = 8;
            this.btnDeleteWord.Text = " Delete Word";
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);
            // 
            // btnEditWord
            // 
            this.btnEditWord.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditWord.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditWord.FocusCuesEnabled = false;
            this.btnEditWord.Location = new System.Drawing.Point(3, 3);
            this.btnEditWord.Name = "btnEditWord";
            this.btnEditWord.Size = new System.Drawing.Size(366, 81);
            this.btnEditWord.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditWord.Symbol = "57940";
            this.btnEditWord.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnEditWord.SymbolSize = 15F;
            this.btnEditWord.TabIndex = 7;
            this.btnEditWord.Text = " Edit Word";
            this.btnEditWord.Click += new System.EventHandler(this.btnEditWord_Click);
            // 
            // gpStudy
            // 
            this.gpStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpStudy.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpStudy.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpStudy.Controls.Add(this.btnMultiRoundStudy);
            this.gpStudy.Controls.Add(this.btnWalkthough);
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
            // btnMultiRoundStudy
            // 
            this.btnMultiRoundStudy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMultiRoundStudy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiRoundStudy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMultiRoundStudy.FocusCuesEnabled = false;
            this.btnMultiRoundStudy.Location = new System.Drawing.Point(3, 91);
            this.btnMultiRoundStudy.Name = "btnMultiRoundStudy";
            this.btnMultiRoundStudy.Size = new System.Drawing.Size(366, 76);
            this.btnMultiRoundStudy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMultiRoundStudy.Symbol = "58837";
            this.btnMultiRoundStudy.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnMultiRoundStudy.SymbolSize = 15F;
            this.btnMultiRoundStudy.TabIndex = 8;
            this.btnMultiRoundStudy.Text = " Multi-Round Study";
            this.btnMultiRoundStudy.Click += new System.EventHandler(this.btnMultiRoundStudy_Click);
            // 
            // btnWalkthough
            // 
            this.btnWalkthough.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWalkthough.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWalkthough.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWalkthough.FocusCuesEnabled = false;
            this.btnWalkthough.Location = new System.Drawing.Point(3, 3);
            this.btnWalkthough.Name = "btnWalkthough";
            this.btnWalkthough.Size = new System.Drawing.Size(366, 81);
            this.btnWalkthough.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWalkthough.Symbol = "57399";
            this.btnWalkthough.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnWalkthough.SymbolSize = 15F;
            this.btnWalkthough.TabIndex = 7;
            this.btnWalkthough.Text = " Walkthough";
            this.btnWalkthough.Click += new System.EventHandler(this.btnWalkthough_Click);
            // 
            // gpExams
            // 
            this.gpExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpExams.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gpExams.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.gpExams.Controls.Add(this.btnFullExam);
            this.gpExams.Controls.Add(this.btnQuickExam);
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
            // btnFullExam
            // 
            this.btnFullExam.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFullExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullExam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFullExam.FocusCuesEnabled = false;
            this.btnFullExam.Location = new System.Drawing.Point(3, 91);
            this.btnFullExam.Name = "btnFullExam";
            this.btnFullExam.Size = new System.Drawing.Size(366, 76);
            this.btnFullExam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFullExam.Symbol = "59511";
            this.btnFullExam.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnFullExam.SymbolSize = 15F;
            this.btnFullExam.TabIndex = 8;
            this.btnFullExam.Text = " Full Exam";
            this.btnFullExam.Click += new System.EventHandler(this.btnFullExam_Click);
            // 
            // btnQuickExam
            // 
            this.btnQuickExam.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuickExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickExam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuickExam.FocusCuesEnabled = false;
            this.btnQuickExam.Location = new System.Drawing.Point(3, 3);
            this.btnQuickExam.Name = "btnQuickExam";
            this.btnQuickExam.Size = new System.Drawing.Size(366, 81);
            this.btnQuickExam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuickExam.Symbol = "59510";
            this.btnQuickExam.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnQuickExam.SymbolSize = 15F;
            this.btnQuickExam.TabIndex = 7;
            this.btnQuickExam.Text = " Quick Exam";
            this.btnQuickExam.Click += new System.EventHandler(this.btnQuickExam_Click);
            // 
            // btnBatch
            // 
            this.btnBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatch.BackColor = System.Drawing.Color.White;
            this.btnBatch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBatch.FocusCuesEnabled = false;
            this.btnBatch.Location = new System.Drawing.Point(191, 7);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(185, 56);
            this.btnBatch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBatch.Symbol = "57672";
            this.btnBatch.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btnBatch.SymbolSize = 12F;
            this.btnBatch.TabIndex = 7;
            this.btnBatch.Text = " Batch";
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
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
        private System.Windows.Forms.ColumnHeader chWords;
        private DevComponents.DotNetBar.Controls.ListViewEx lvGroups;
        private System.Windows.Forms.ColumnHeader chGroups;
        private DevComponents.DotNetBar.ButtonX btnAddGroup;
        private DevComponents.DotNetBar.ButtonX btnAddWord;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnLearn;
        private DevComponents.DotNetBar.RadialMenu rmSettings;
        private System.Windows.Forms.FlowLayoutPanel flpControls;
        private DevComponents.DotNetBar.Controls.GroupPanel gpOperations;
        private DevComponents.DotNetBar.ButtonX btnDeleteWord;
        private DevComponents.DotNetBar.ButtonX btnEditWord;
        private DevComponents.DotNetBar.Controls.GroupPanel gpStudy;
        private DevComponents.DotNetBar.ButtonX btnMultiRoundStudy;
        private DevComponents.DotNetBar.ButtonX btnWalkthough;
        private DevComponents.DotNetBar.Controls.GroupPanel gpExams;
        private DevComponents.DotNetBar.ButtonX btnFullExam;
        private DevComponents.DotNetBar.ButtonX btnQuickExam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx dbSelector;
        private DevComponents.DotNetBar.ButtonX btnImport;
        private DevComponents.DotNetBar.RadialMenu rmGroup;
        private DevComponents.DotNetBar.RadialMenuItem riClearStudyRecord;
        private DevComponents.DotNetBar.RadialMenuItem riDelete;
        private DevComponents.DotNetBar.RadialMenuItem riRename;
        private DevComponents.DotNetBar.RadialMenuItem riExport;
        private DevComponents.DotNetBar.ButtonX btnBatch;
    }
}