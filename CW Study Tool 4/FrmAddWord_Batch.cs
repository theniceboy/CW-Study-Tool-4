using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using DevComponents.DotNetBar.Controls;

namespace CW_Study_Tool_4 {
    public partial class FrmAddWord_Batch : DevComponents.DotNetBar.Metro.MetroForm {
        private SQLiteCommand cmdAddWord;
        private SQLiteConnection dictConnection;
        private string originTitle;

        private string strSQLInsert =
            "INSERT INTO words (`word`, `trans`, `group`, `state`, `gamestate`) VALUES (@word, @trans, @group, @state, @gamestate)";

        public FrmAddWord_Batch() {
            InitializeComponent();
        }

        string lookupDict(string word) {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words WHERE `word`=@word", dictConnection);
            cmd.Parameters.AddWithValue("@word", word);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try {
                reader.Read();
                return reader["explain"].ToString();
            } catch { }
            return "";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (tbWords.Text.Trim() == "") {
                ToastNotification.Show(this, "You must input at least one word!", null, 2000, eToastGlowColor.Red);
                return;
            }
            int count = tbWords.Lines.Count(), js = 0;
            foreach (var word in tbWords.Lines) {
                string new_word = word.Trim();
                if (new_word != "")
                {
                    this.Text = originTitle + " ( " + ((double) ++js * 100.0 / (double) count) + "% )";
                    cmdAddWord = new SQLiteCommand(strSQLInsert, Gib.con);
                    cmdAddWord.Parameters.AddWithValue("@word", new_word);
                    cmdAddWord.Parameters.AddWithValue("@trans", lookupDict(new_word));
                    cmdAddWord.Parameters.AddWithValue("@group", Gib.curGroup);
                    cmdAddWord.Parameters.AddWithValue("@state", 0);
                    cmdAddWord.Parameters.AddWithValue("@gamestate", 0);
                    cmdAddWord.ExecuteNonQuery();
                }
            }
            this.Text = originTitle + " ( 100% )";
            MessageBox.Show(js + " word" + (js > 1 ? "s" : "") + " added");
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshWords();
            tbWords.Text = "";
            this.Close();
        }
        
        private void FrmKeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A)
                try { ((TextBoxX) sender).SelectAll(); }
                catch {
                }
        }

        private void FrmAddWord_FormClosing(object sender, FormClosingEventArgs e) {
            if (tbWords.Text.Trim() != "") {
                if (MessageBox.Show(this, "Are you sure you want to discard these words you've entered?",
                        "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2) == DialogResult.No) {
                    e.Cancel = true;
                }
            }
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshWords();
        }

        private void FrmAddWord_Load(object sender, EventArgs e) {
            pnMain.BackColor = Color.White;
            originTitle = this.Text;
            dictSelector.SelectedItem = ciNone;
        }

        private void dictSelector_SelectedIndexChanged(object sender, EventArgs e) {
            if (dictSelector.SelectedItem == ciEnglish_Chinese) {
                if (!File.Exists(Gib.hostpath + "\\ConciseOxfordEnglishChineseDictionary.db")) {
                    dictSelector.SelectedItem = ciNone;
                    FrmDownload_Dict frm = new FrmDownload_Dict();
                    frm.ShowDialog(this);
                }
                else {
                    dictConnection =
                        new SQLiteConnection("Data Source =" + Gib.hostpath +
                                             "\\ConciseOxfordEnglishChineseDictionary.db");
                    dictConnection.Open();
                }
            }
        }

        public void dict_English_Chinese_complete() {
            try {
                dictConnection.Close();
            } catch { }
            dictSelector.SelectedItem = ciEnglish_Chinese;
            dictConnection = new SQLiteConnection("Data Source =" + Gib.hostpath + "\\ConciseOxfordEnglishChineseDictionary.db");
            dictConnection.Open();
        }
    }
}
