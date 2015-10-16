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

namespace CW_Study_Tool_4
{
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        void beginCheck()
        {
            bool flag = !File.Exists(Gib.dbpath);
            if (!Directory.Exists(Gib.compath))
                Directory.CreateDirectory(Gib.compath);
            if (!Directory.Exists(Gib.hostpath))
                Directory.CreateDirectory(Gib.hostpath);
            if (!File.Exists(Gib.hostpath + "\\DefaultDB"))
            {
                File.WriteAllText(Gib.hostpath + "\\DefaultDB", "0");
                Gib.curDB = 0;
            }
            else
                try
                {
                    Gib.curDB = Convert.ToInt32(File.ReadAllText(Gib.hostpath + "\\DefaultDB"));
                }
                catch (Exception)
                {
                    throw; // DEBUG ONLY !!!
                    File.WriteAllText(Gib.hostpath + "\\DefaultDB", "0");
                    Gib.curDB = 0;
                }


            Gib.con = new SQLiteConnection("Data Source =" + Gib.dbpath);
            Gib.con.Open();

            SQLiteCommand cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `words` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `word` TEXT, `trans` TEXT, `group` INTEGER, `state` INTEGER, `gamestate` INTEGER);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `groups` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `group` TEXT, `db` INTEGER);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `db` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `name` TEXT);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            if (flag)
            {
                SQLiteCommand cmdAdd = new SQLiteCommand("INSERT INTO db (`name`) VALUES ('Default Collection')", Gib.con);
                cmdAdd.ExecuteNonQuery();
            }

            selectDB();
            refreshDBList();
        }

        bool selectDB()
        {
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

        void refreshDBList()
        {
            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;
            cmdSearch = new SQLiteCommand("SELECT * FROM db", Gib.con);
            reader = cmdSearch.ExecuteReader();
            dbSelector.Items.Clear();
            while (reader.Read())
            {
                ComboBoxItem item = new ComboBoxItem(reader["id"].ToString(), reader["name"].ToString());
                dbSelector.Items.Add(item);
                if (Convert.ToInt32(reader["id"]) == Gib.curDB)
                    dbSelector.SelectedItem = item;
            }
        }

        public void refreshGroups()
        {
            lvGroups.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;

            cmdSearch = new SQLiteCommand("SELECT * FROM groups WHERE `db`=@db", Gib.con);
            cmdSearch.Parameters.AddWithValue("@db", Gib.curDB);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = Convert.ToInt32(reader["id"]);
                lvItem.Text = reader["group"].ToString();
                lvGroups.Items.Add(lvItem);
            }
            if (lvGroups.Items.Count > 0)
                rmGroup.Enabled = true;

            chGroups.Text = lvGroups.Items.Count.ToString() + " Groups";
        }

        public void refreshWords()
        {
            lvWords.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;

            cmdSearch = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group", Gib.con);
            cmdSearch.Parameters.AddWithValue("@group", Gib.curGroup);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Tag = Convert.ToInt32(reader["id"]);
                lvItem.Text = reader["word"].ToString();
                lvWords.Items.Add(lvItem);
            }

            chWords.Text = lvWords.Items.Count.ToString() + " Words";
            gpStudy.Enabled = gpExams.Enabled = (lvWords.Items.Count > 0);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            beginCheck();
            pnMain.BackColor = pnWords.BackColor = pnLearn.BackColor = flpControls.BackColor = Color.White;

            refreshGroups();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            FrmAddGroup frm = new FrmAddGroup();
            frm.ShowDialog(this);
        }

        private void lvGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups.SelectedItems.Count > 0)
            {
                Gib.curGroup = (int) lvGroups.SelectedItems[0].Tag;
                refreshWords();
                rmGroup.Enabled = pnWords.Enabled = true;
            }
            else
            {
                lvWords.Items.Clear();
                rmGroup.Enabled = pnWords.Enabled = gpStudy.Enabled = gpExams.Enabled = false;
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            FrmAddWord frm = new FrmAddWord();
            frm.ShowDialog(this);
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWords.SelectedItems.Count > 0)
            {
                Gib.curWord = (int) lvWords.SelectedItems[0].Tag;
                gpOperations.Enabled = true;
            }
            else
            {
                gpOperations.Enabled = false;
            }
        }

        private void rmGroup_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnEditWord_Click(object sender, EventArgs e)
        {
            FrmEditWord frm = new FrmEditWord();
            frm.ShowDialog(this);
        }

        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(this, "Are you sure you want to delete this word? You cannot undu this operation",
                    "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) ==
                DialogResult.Yes)
            {
                SQLiteCommand cmdDelete = new SQLiteCommand("DELETE FROM words WHERE `id`=@id", Gib.con);
                cmdDelete.Parameters.AddWithValue("@id", Gib.curWord);
                cmdDelete.ExecuteNonQuery();
                refreshWords();
            }
        }

        private void btnWalkthough_Click(object sender, EventArgs e)
        {
            Gib.studymode = 0;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void btnMultiRoundStudy_Click(object sender, EventArgs e)
        {

        }

        private void btnQuickExam_Click(object sender, EventArgs e)
        {

        }

        private void btnFullExam_Click(object sender, EventArgs e)
        {

        }

        private void dbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rmSettings_ItemClick(object sender, EventArgs e)
        {

        }
    }
}