using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFormat {
    public partial class FrmMain : Form {
        private SQLiteConnection dictConnection, con;
        private static string compath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\CW Soft";
        private static string hostpath = compath + "\\CW Study Tool 4";
        private string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\e4.db";
        private string txtpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\e4.txt";

        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            con = new SQLiteConnection("Data Source =" + dbpath);
            con.Open();

            SQLiteCommand cmdCreateTable =
                new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `Words` (`word` TEXT, `explain` TEXT, );",
                    con);
            cmdCreateTable.ExecuteNonQuery();

            dictConnection = new SQLiteConnection("Data Source =" + hostpath + "\\ConciseOxfordEnglishChineseDictionary.db");
            dictConnection.Open();
        }
    }
}
