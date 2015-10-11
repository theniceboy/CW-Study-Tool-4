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

        private string strSQLInsert =
            "INSERT INTO words (word, trans, group, state) VALUES (@word, @trans, @group, @state)";

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
            cmdAddWord.Parameters.AddWithValue("@word", tbWord.Text.Trim());
            cmdAddWord.Parameters.AddWithValue("@trans", tbTrans.Text);
            cmdAddWord.Parameters.AddWithValue("@group", 1);
            cmdAddWord.Parameters.AddWithValue("@state", 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}