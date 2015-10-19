using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_4 {
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm {
        public FrmMain() {
            InitializeComponent();
        }

        private void beginCheck() {
            bool flag = !File.Exists(Gib.dbpath);
            if (!Directory.Exists(Gib.compath))
                Directory.CreateDirectory(Gib.compath);
            if (!Directory.Exists(Gib.hostpath))
                Directory.CreateDirectory(Gib.hostpath);
            if (!File.Exists(Gib.hostpath + "\\DefaultDB")) {
                File.WriteAllText(Gib.hostpath + "\\DefaultDB", "1");
                Gib.curDB = 0;
            }
            else
                try {
                    Gib.curDB = Convert.ToInt32(File.ReadAllText(Gib.hostpath + "\\DefaultDB"));
                }
                catch (Exception) {
                    throw; // DEBUG ONLY !!!
                    File.WriteAllText(Gib.hostpath + "\\DefaultDB", "0");
                    Gib.curDB = 0;
                }


            Gib.con = new SQLiteConnection("Data Source =" + Gib.dbpath);
            Gib.con.Open();

            SQLiteCommand cmdCreateTable =
                new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `words` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `word` TEXT, `trans` TEXT, `group` INTEGER, `state` INTEGER, `gamestate` INTEGER);",
                    Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable =
                new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `groups` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `group` TEXT, `db` INTEGER);",
                    Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable =
                new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `db` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` TEXT);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            if (flag) {
                SQLiteCommand cmdAdd = new SQLiteCommand("INSERT INTO db (`name`) VALUES ('Default Collection')",
                    Gib.con);
                cmdAdd.ExecuteNonQuery();
            }

            selectDB();
            refreshDBList();
        }

        private bool selectDB() {
            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;
            cmdSearch = new SQLiteCommand("SELECT * FROM db WHERE `id`=@groupID", Gib.con);
            cmdSearch.Parameters.AddWithValue("@groupID", Gib.curDB);
            reader = cmdSearch.ExecuteReader();
            if (reader.HasRows)
                return true;
            cmdSearch = new SQLiteCommand("SELECT * FROM db", Gib.con);
            reader = cmdSearch.ExecuteReader();
            reader.Read();
            Gib.curDB = Convert.ToInt32(reader["id"]);
            return false;
        }

        public void refreshDBList() {
            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;
            cmdSearch = new SQLiteCommand("SELECT * FROM db", Gib.con);
            reader = cmdSearch.ExecuteReader();
            dbSelector.Items.Clear();
            while (reader.Read()) {
                ComboBoxItem item = new ComboBoxItem();
                item.Tag = Convert.ToInt32(reader["id"].ToString());
                item.Text = reader["name"].ToString();
                dbSelector.Items.Add(item);
                if (Convert.ToInt32(reader["id"]) == Gib.curDB)
                    dbSelector.SelectedItem = item;
            }
        }

        public void refreshGroups() {
            lvGroups.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;

            cmdSearch = new SQLiteCommand("SELECT * FROM groups WHERE `db`=@db", Gib.con);
            cmdSearch.Parameters.AddWithValue("@db", Gib.curDB);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read()) {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = Convert.ToInt32(reader["id"]);
                lvItem.Text = reader["group"].ToString();
                lvGroups.Items.Add(lvItem);
            }

            chGroups.Text = lvGroups.Items.Count.ToString() + " Groups";
        }

        public void refreshWords() {
            lvWords.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;
            int tmp;

            cmdSearch = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group", Gib.con);
            cmdSearch.Parameters.AddWithValue("@group", Gib.curGroup);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read()) {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = Convert.ToInt32(reader["id"]);
                lvItem.Text = reader["word"].ToString();
                lvItem.ToolTipText = reader["trans"].ToString();
                tmp = Convert.ToInt32(reader["state"]);
                lvItem.ForeColor = (tmp == 0 ? Color.Black : (tmp == 1 ? Color.Green : Color.DarkRed));
                lvWords.Items.Add(lvItem);
            }

            chWords.Text = lvWords.Items.Count.ToString() + " Words";
            gpStudy.Enabled = gpExams.Enabled = (lvWords.Items.Count > 0);
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            beginCheck();
            pnMain.BackColor = pnWords.BackColor = pnLearn.BackColor = flpControls.BackColor = Color.White;

            refreshGroups();
        }

        private void btnAddGroup_Click(object sender, EventArgs e) {
            FrmAddGroup frm = new FrmAddGroup();
            frm.ShowDialog(this);
        }

        private void lvGroups_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvGroups.SelectedItems.Count > 0) {
                Gib.curGroup = (int) lvGroups.SelectedItems[0].Tag;
                refreshWords();
                rmGroup.Enabled = pnWords.Enabled = true;
            }
            else {
                lvWords.Items.Clear();
                chWords.Text = "Words";
                rmGroup.Enabled = pnWords.Enabled = gpStudy.Enabled = gpExams.Enabled = false;
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e) {
            FrmAddWord frm = new FrmAddWord();
            frm.ShowDialog(this);
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvWords.SelectedItems.Count > 0) {
                Gib.curWord = (int) lvWords.SelectedItems[0].Tag;
                gpOperations.Enabled = true;
            }
            else {
                gpOperations.Enabled = false;
            }
        }

        private void rmGroup_ItemClick(object sender, EventArgs e) {
            if (sender == riClearStudyRecord) {
                if (MessageBox.Show(this,
                    "Are you sure you want to clear all the study record in this group?  You cannot undo this operation!",
                    "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    SQLiteCommand cmd;
                    cmd = new SQLiteCommand("UPDATE words SET `state`=0 WHERE `group`=@group", Gib.con);
                    cmd.Parameters.AddWithValue("@group", Gib.curGroup);
                    cmd.ExecuteNonQuery();
                    refreshWords();
                }
            }
            else if (sender == riDelete) {
                if (MessageBox.Show(this,
                    "Are you sure you want to delete this group and ALL the words in this group?  You cannot undo this operation!",
                    "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes) {
                    SQLiteCommand cmd;
                    cmd = new SQLiteCommand("DELETE FROM words WHERE `group`=@group", Gib.con);
                    cmd.Parameters.AddWithValue("@group", Gib.curGroup);
                    cmd.ExecuteNonQuery();

                    cmd = new SQLiteCommand("DELETE FROM groups WHERE `id`=@id", Gib.con);
                    cmd.Parameters.AddWithValue("@id", Gib.curGroup);
                    cmd.ExecuteNonQuery();

                    refreshGroups();
                    lvGroups_SelectedIndexChanged(sender, e);
                }
            }
            else if (sender == riExport) {
                saveFileDialog.FileName = "My Group.cgdb";
                saveFileDialog.Filter = "CW Study Tool 4 Word Group (*.cgdb)|*.cgdb";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                    SQLiteConnection econ = new SQLiteConnection("Data Source =" + saveFileDialog.FileName);
                    econ.Open();

                    SQLiteCommand cmdCreateTable =
                        new SQLiteCommand("CREATE TABLE IF NOT EXISTS `words` (`word` TEXT, `trans` TEXT);", econ);
                    cmdCreateTable.ExecuteNonQuery();

                    SQLiteCommand cmdSearch, cmdAdd;
                    SQLiteDataReader reader;
                    string insertSQL = "INSERT INTO words (`word`, `trans`) VALUES (@word, @trans)";
                    cmdSearch = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group", Gib.con);
                    cmdSearch.Parameters.AddWithValue("@group", Gib.curGroup);
                    reader = cmdSearch.ExecuteReader();
                    while (reader.Read())
                    {
                        cmdAdd = new SQLiteCommand(insertSQL, econ);
                        cmdAdd.Parameters.AddWithValue("@word", reader["word"].ToString());
                        cmdAdd.Parameters.AddWithValue("@trans", reader["trans"].ToString());
                        cmdAdd.ExecuteNonQuery();
                    }

                    econ.Close();
                    econ.Dispose();

                    ToastNotification.Show(this, "This group of words has been successfully exported", null, 2000);
                }
            }
            else if (sender == riRename) {
                FrmRenameGroup frm = new FrmRenameGroup();
                frm.ShowDialog(this);
            }
        }

        private void btnEditWord_Click(object sender, EventArgs e) {
            FrmEditWord frm = new FrmEditWord();
            frm.ShowDialog(this);
        }

        private void btnDeleteWord_Click(object sender, EventArgs e) {
            if (
                MessageBox.Show(this, "Are you sure you want to delete this word? You cannot undo this operation!",
                    "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) ==
                DialogResult.Yes) {
                SQLiteCommand cmdDelete = new SQLiteCommand("DELETE FROM words WHERE `id`=@id", Gib.con);
                cmdDelete.Parameters.AddWithValue("@id", Gib.curWord);
                cmdDelete.ExecuteNonQuery();
                refreshWords();
            }
        }

        private void btnWalkthough_Click(object sender, EventArgs e) {
            Gib.studymode = 0;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void btnMultiRoundStudy_Click(object sender, EventArgs e) {
            Gib.studymode = 1;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void btnQuickExam_Click(object sender, EventArgs e) {

        }

        private void btnFullExam_Click(object sender, EventArgs e) {

        }

        private void dbSelector_SelectedIndexChanged(object sender, EventArgs e) {
            SQLiteCommand cmd = new SQLiteCommand("SELECT `id` FROM db WHERE `name`=@name", Gib.con);
            cmd.Parameters.AddWithValue("@name", dbSelector.SelectedItem.ToString());
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Gib.curDB = Convert.ToInt32(reader["id"]);
            refreshGroups();
        }

        private void rmSettings_ItemClick(object sender, EventArgs e) {
            if (sender == riImportDB) {
                FrmDownloadCollection frm = new FrmDownloadCollection();
                frm.ShowDialog(this);
            }
        }

        private void pnMain_BackColorChanged(object sender, EventArgs e) {
            pnMain.BackColor = Color.White;
        }

        private void pnWords_BackColorChanged(object sender, EventArgs e) {
            pnWords.BackColor = Color.White;
        }

        private void pnLearn_BackColorChanged(object sender, EventArgs e) {
            pnLearn.BackColor = Color.White;
        }

        private void flpControls_BackColorChanged(object sender, EventArgs e) {
            flpControls.BackColor = Color.White;
        }

        public void btnBatch_Click(object sender, EventArgs e) {
            FrmAddWord_Batch frm = new FrmAddWord_Batch();
            frm.ShowDialog(this);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
