using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using System.Data.SQLite;
using System.IO;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_4
{
    public partial class FrmMain1 : MetroForm
    {
        public FrmMain1()
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
            
            SQLiteCommand cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `words` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `word` TEXT, `trans` TEXT, `group` INTEGER, `state` INTEGER);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();
            
            cmdCreateTable = new SQLiteCommand("CREATE TABLE IF NOT EXISTS `group` (`id` INTEGER PRIMARY KEY AUTOINCREMENT, `group` TEXT);", Gib.con);
            cmdCreateTable.ExecuteNonQuery();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            beginCheck();
            pnWords.BackColor = Color.White;
        }

        private void lvGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
