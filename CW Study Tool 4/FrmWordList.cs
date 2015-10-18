using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_4 {
    public partial class FrmWordList : DevComponents.DotNetBar.Metro.MetroForm {
        public FrmWordList() {
            InitializeComponent();
        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvWords.SelectedItems.Count > 0) {
                ListViewItem item = lvWords.SelectedItems[0];
                if (item.ForeColor == Color.DarkRed) {
                    btnBad.Checked = true;
                    btnGood.Checked = false;
                }
                else if (item.ForeColor == Color.Green) {
                    btnBad.Checked = false;
                    btnGood.Checked = true;
                }
                else
                    btnBad.Checked = btnGood.Checked = false;
            }
            else
                btnBad.Checked = btnGood.Checked = false;
        }

        private void FrmWordList_Load(object sender, EventArgs e) {
            pnMain.BackColor = Color.White;

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
        }

        private void btnBad_Click(object sender, EventArgs e) {
            if (lvWords.SelectedItems.Count > 0) {
                ListViewItem item = lvWords.SelectedItems[0];
                if (item.ForeColor != Color.DarkRed) {
                    int id = Convert.ToInt32(item.Tag);
                    item.ForeColor = Color.DarkRed;
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE words SET `state`=@state WHERE `id`=@id", Gib.con);
                    cmd.Parameters.AddWithValue("@state", 2);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnGood_Click(object sender, EventArgs e) {
            if (lvWords.SelectedItems.Count > 0) {
                ListViewItem item = lvWords.SelectedItems[0];
                if (item.ForeColor != Color.Green) {
                    int id = Convert.ToInt32(item.Tag);
                    item.ForeColor = Color.Green;
                    SQLiteCommand cmd = new SQLiteCommand("UPDATE words SET `state`=@state WHERE `id`=@id", Gib.con);
                    cmd.Parameters.AddWithValue("@state", 1);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
