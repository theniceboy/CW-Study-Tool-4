using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SQLite;
using DevComponents.DotNetBar.Controls;

namespace CW_Study_Tool_4
{
    public partial class FrmAddWord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private SQLiteCommand cmdAddWord;
        private SQLiteCommand cmdSearch;
        private SQLiteDataReader reader;
        private string word = "";

        private string strSQLInsert =
            "INSERT INTO words (word, trans, groupName, state, gamestate) VALUES (@word, @trans, @group, @state, @gamestate)";

        public FrmAddWord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbWord.Text.Trim() == "")
            {
                ToastNotification.Show(this, "New word cannot be empty!", null, 2000, eToastGlowColor.Red);
                return;
            }
            cmdAddWord = new SQLiteCommand(strSQLInsert, Gib.con);
            cmdAddWord.Parameters.AddWithValue("@word", word);
            cmdAddWord.Parameters.AddWithValue("@trans", tbTrans.Text);
            cmdAddWord.Parameters.AddWithValue("@group", Gib.curGroup);
            cmdAddWord.Parameters.AddWithValue("@state", 0);
            cmdAddWord.Parameters.AddWithValue("@gamestate", 0);
            cmdAddWord.ExecuteNonQuery();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTrans.Text = tbWord.Text = "";
            btnAdd.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmAddWord_Help frm = new FrmAddWord_Help();
            frm.ShowDialog(this);
        }

        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            word = tbWord.Text.Trim();
            if (word == "")
            {
                lbError.Text = "";
                btnAdd.Enabled = false;
                return;
            }
            cmdSearch = new SQLiteCommand("SELECT * FROM words WHERE `word`=@word", Gib.con);
            cmdSearch.Parameters.AddWithValue("@word", word);
            reader = cmdSearch.ExecuteReader();
            if (reader.HasRows)
            {
                lbError.Text = "The word \"" + word + "\" already exists";
                btnAdd.Enabled = false;
            }
            else
            {
                lbError.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void FrmKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter && btnAdd.Enabled)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void FrmAddWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshWords();
        }
    }
}