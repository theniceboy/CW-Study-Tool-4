using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_4
{
    public partial class FrmAddGroup : DevComponents.DotNetBar.Metro.MetroForm
    {
        private string group;
        private SQLiteCommand cmdSearch;
        private SQLiteDataReader reader;

        public FrmAddGroup()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmdAdd = new SQLiteCommand("INSERT INTO groups (`group`, `db`) VALUES (@group, " + Gib.curDB + ")", Gib.con);
            cmdAdd.Parameters.AddWithValue("@group", group);
            cmdAdd.ExecuteNonQuery();
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshGroups();
            this.Close();
        }

        private void tbGroup_TextChanged(object sender, EventArgs e)
        {
            group = tbGroup.Text.Trim();
            if (group == "")
            {
                lbError.Text = "";
                btnAdd.Enabled = false;
                return;
            }
            cmdSearch = new SQLiteCommand("SELECT * FROM groups WHERE `group`=@group AND `db`=@db", Gib.con);
            cmdSearch.Parameters.AddWithValue("@group", group);
            cmdSearch.Parameters.AddWithValue("@db", Gib.curDB);
            reader = cmdSearch.ExecuteReader();
            if (reader.HasRows)
            {
                lbError.Text = "Group name exists";
                btnAdd.Enabled = false;
            }
            else
            {
                lbError.Text = "";
                btnAdd.Enabled = true;
            }
        }

        private void FrmAddGroup_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            lbError.ForeColor = Color.DarkRed;
            pnMain.BackColor = Color.White;
        }

        private void tbGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}