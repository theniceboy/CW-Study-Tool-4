using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
       
        string lookupDict(string word)
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Words WHERE `word`=@word", dictConnection);
            cmd.Parameters.AddWithValue("@word", word);
            SQLiteDataReader reader = cmd.ExecuteReader();
            try
            {
                reader.Read();
                return reader["explain"].ToString();
            }
            catch { }
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SQLiteConnection("Data Source =" + dbpath);
            con.Open();

            SQLiteCommand cmdCreateTable = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `Words` (`word` TEXT, `explain` TEXT, `group` TEXT);", con);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable = new SQLiteCommand(
                    "CREATE TABLE IF NOT EXISTS `Groups` (`group` TEXT);", con);
            cmdCreateTable.ExecuteNonQuery();

            dictConnection =
                new SQLiteConnection("Data Source =" + hostpath + "\\ConciseOxfordEnglishChineseDictionary.db");
            dictConnection.Open();

            SQLiteCommand cmdInsert, cmdGroup;
            string[] lines = File.ReadAllLines(txtpath, Encoding.Default);

            int i, j, n = lines.Count(), m;
            string word, trans, sqlInsert = "INSERT INTO Words (`word`, `explain`, `group`) VALUES (@word, @explain, @group);";
            string sqlGroup = "INSERT INTO Groups (`group`) VALUES (@group);", curGroup = "";
            n -= 2;
            for (i = 0; i < n; ++i) {
                progressBar2.Value = (int) ((double) i*100.0/(double) n);
                progressBar2.Refresh();
                if (lines[i] == "" && lines[i + 1] == "")
                {
                    i += 2;
                    curGroup = lines[i];
                    cmdGroup = new SQLiteCommand(sqlGroup, con);
                    cmdGroup.Parameters.AddWithValue("@group", curGroup);
                    cmdGroup.ExecuteNonQuery();
                    continue;
                }
                m = lines[i].ToCharArray().Length;
                word = trans = "";
                for (j = 0; j < m; ++j)
                {
                    if (lines[i][j] == ' ')
                        break;
                    word += lines[i][j];
                }
                word = word.Trim();
                ++j;
                for (; j < m; ++j)
                    trans += lines[i][j];
                if (trans.Trim() == "")
                    trans = lookupDict(word);
                cmdInsert = new SQLiteCommand(sqlInsert, con);
                cmdInsert.Parameters.AddWithValue("@word", word);
                cmdInsert.Parameters.AddWithValue("@explain", trans);
                cmdInsert.Parameters.AddWithValue("@group", curGroup);
                cmdInsert.ExecuteNonQuery();
            }
            progressBar2.Value = 100;
            MessageBox.Show("Done!");
        }

        private void FrmMain_Load(object sender, EventArgs e) {
        }
    }
}
