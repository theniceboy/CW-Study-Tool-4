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
            if (!Directory.Exists(Gib.compath))
                Directory.CreateDirectory(Gib.compath);
            if (!Directory.Exists(Gib.hostpath))
                Directory.CreateDirectory(Gib.hostpath);

            Gib.con = new SQLiteConnection("Data Source =" + Gib.dbpath);
            Gib.con.Open();

            SQLiteCommand cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `words` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `word` TEXT, `trans` TEXT, `groupName` TEXT, `state` INTEGER, `gamestate` INTEGER);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();

            cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `groups` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `group` TEXT);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();
        }

        public void refreshGroups()
        {
            lvGroups.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;

            cmdSearch = new SQLiteCommand("SELECT * FROM groups", Gib.con);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = (string) reader["group"];
                lvGroups.Items.Add(lvItem);
            }
        }

        public void refreshWords()
        {
            lvWords.Items.Clear();

            SQLiteCommand cmdSearch;
            SQLiteDataReader reader;

            cmdSearch = new SQLiteCommand("SELECT * FROM words", Gib.con);
            reader = cmdSearch.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = (string)reader["word"];
                lvWords.Items.Add(lvItem);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            beginCheck();
            pnWords.BackColor = Color.White;

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
                Gib.curWord = lvGroups.SelectedItems[0].Text;
                refreshWords();
                btnExport.Enabled = btnAddWord.Enabled = true;
            }
            else
            {
                lvWords.Items.Clear();
                btnExport.Enabled = btnAddWord.Enabled = false;
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            FrmAddWord frm = new FrmAddWord();
            frm.ShowDialog(this);
        }

        public void loadWord()
        {
            
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGroups.SelectedItems.Count > 0)
            {
                Gib.curWord = lvGroups.SelectedItems[0].Text;
                loadWord();
            }
        }
    }
}