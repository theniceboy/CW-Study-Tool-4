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

namespace CW_Study_Tool_4 {
    public partial class FrmEditWord : DevComponents.DotNetBar.Metro.MetroForm {
        private SQLiteCommand cmdAddWord;
        private SQLiteCommand cmdSearch;
        private SQLiteDataReader reader;
        private string word = "";

        private string strSQLInsert =
            "UPDATE words SET `word`=@word, `trans`=@trans, `group`=@group WHERE `id`=@id";

        public FrmEditWord() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (tbWord.Text.Trim() == "") {
                ToastNotification.Show(this, "Word cannot be empty!", null, 2000, eToastGlowColor.Red);
                return;
            }
            cmdAddWord = new SQLiteCommand(strSQLInsert, Gib.con);
            cmdAddWord.Parameters.AddWithValue("@word", word);
            cmdAddWord.Parameters.AddWithValue("@trans", tbTrans.Text);
            cmdAddWord.Parameters.AddWithValue("@group", Gib.curGroup);
            cmdAddWord.Parameters.AddWithValue("@id", Gib.curWord);
            cmdAddWord.ExecuteNonQuery();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e) {
            tbTrans.Text = tbWord.Text = "";
            btnAdd.Enabled = false;
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            FrmAddWord_Help frm = new FrmAddWord_Help();
            frm.ShowDialog(this);
        }

        private void tbWord_TextChanged(object sender, EventArgs e) {
            word = tbWord.Text.Trim();
            if (word == "") {
                lbError.Text = "";
                btnAdd.Enabled = false;
                return;
            }
            cmdSearch = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group AND `word`=@word AND `id`<>@id",
                Gib.con);
            cmdSearch.Parameters.AddWithValue("@group", Gib.curGroup);
            cmdSearch.Parameters.AddWithValue("@word", word);
            cmdSearch.Parameters.AddWithValue("@id", Gib.curWord);
            reader = cmdSearch.ExecuteReader();
            if (reader.HasRows) {
                lbError.Text = "The word \"" + word + "\" already exists in your current group";
                btnAdd.Enabled = false;
            }
            else {
                lbError.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void FrmKeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.Enter && btnAdd.Enabled) {
                btnAdd_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.A)
                try {
                    ((TextBoxX) sender).SelectAll();
                }
                catch {
                }
        }

        private void FrmAddWord_FormClosing(object sender, FormClosingEventArgs e) {
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshWords();
        }

        private void initInterface() {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM words WHERE `id`=@id", Gib.con);
            cmd.Parameters.AddWithValue("@id", Gib.curWord);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                reader.Read();
                tbWord.Text = reader["word"].ToString();
                tbTrans.Text = reader["trans"].ToString();
            }
            else {
                MessageBoxEx.Show(this, "The word not exists");
                this.Close();
            }
        }

        private void FrmAddWord_Load(object sender, EventArgs e) {
            pnMain.BackColor = Color.White;
            lbError.ForeColor = Color.DarkRed;
            initInterface();
        }
    }
}
