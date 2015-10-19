using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace CW_Study_Tool_4 {
    public partial class FrmRenameGroup : DevComponents.DotNetBar.Metro.MetroForm {
        private string group;
        private SQLiteCommand cmdSearch;
        private SQLiteDataReader reader;

        public FrmRenameGroup() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            SQLiteCommand cmdRename =
                new SQLiteCommand("UPDATE groups SET `group`=@group WHERE `id`=@id", Gib.con);
            cmdRename.Parameters.AddWithValue("@group", group);
            cmdRename.Parameters.AddWithValue("@id", Gib.curGroup);
            cmdRename.ExecuteNonQuery();
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshGroups();
            this.Close();
        }

        private void tbGroup_TextChanged(object sender, EventArgs e) {
            group = tbGroup.Text.Trim();
            if (group == "") {
                lbError.Text = "";
                btnAdd.Enabled = false;
                return;
            }
            cmdSearch = new SQLiteCommand("SELECT * FROM groups WHERE `group`=@group AND `db`=@db AND `id`<>@id", Gib.con);
            cmdSearch.Parameters.AddWithValue("@group", group);
            cmdSearch.Parameters.AddWithValue("@db", Gib.curDB);
            cmdSearch.Parameters.AddWithValue("@id", Gib.curGroup);
            reader = cmdSearch.ExecuteReader();
            if (reader.HasRows) {
                lbError.Text = "Group name exists";
                btnAdd.Enabled = false;
            }
            else {
                lbError.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void FrmAddGroup_Load(object sender, EventArgs e) {
            btnAdd.Enabled = false;
            lbError.ForeColor = Color.DarkRed;
            pnMain.BackColor = Color.White;

            cmdSearch = new SQLiteCommand("SELECT `group` FROM groups WHERE `id`=@id", Gib.con);
            cmdSearch.Parameters.AddWithValue("@id", Gib.curGroup);
            reader = cmdSearch.ExecuteReader();
            reader.Read();
            tbGroup.Text = reader["group"].ToString();
        }

        private void tbGroup_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled) {
                btnAdd_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.A)
                try {
                    ((TextBoxX) sender).SelectAll();
                } catch { }
        }
    }
}
