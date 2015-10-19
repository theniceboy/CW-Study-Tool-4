using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_4 {
    public partial class FrmDownloadCollection : DevComponents.DotNetBar.Metro.MetroForm {
        private string dbpath = "";

        public FrmDownloadCollection() {
            InitializeComponent();
        }

        private void FrmDownloadCollection_Load(object sender, EventArgs e) {
            dbSelector.SelectedItem = ciCET4;
        }

        private void btnDownload_Click(object sender, EventArgs e) {
            btnDownload.Text = " Importing...";
            if (dbSelector.SelectedItem == ciCET4) {
                dbpath = Gib.hostpath + "\\ChinaCET4.db";
                if (File.Exists(dbpath)) {
                    SQLiteCommand cmdSearch;
                    SQLiteDataReader reader;
                    cmdSearch = new SQLiteCommand("SELECT * FROM db WHERE `name`='China CET 4'", Gib.con);
                    reader = cmdSearch.ExecuteReader();
                    if (reader.HasRows) {
                        MessageBox.Show("You've already downloaded and imported this collection!", "CW Study Tool");
                        this.Close();
                    }
                    Import();
                }
                else {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    webClient.DownloadFileAsync(new Uri("http://7xnkmd.dl1.z0.glb.clouddn.com/ChinaCET4.db"), dbpath);
                }
            }
        }

        private string strSQLInsert =
            "INSERT INTO words (`word`, `trans`, `group`, `state`, `gamestate`) VALUES (@word, @trans, @group, @state, @gamestate)";

        void Import() {
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO db (`name`) VALUES ('China CET 4')",
                Gib.con);
            SQLiteDataReader reader;
            cmd.ExecuteNonQuery();
            cmd = new SQLiteCommand("SELECT `id` FROM db WHERE `name`='China CET 4'", Gib.con);
            reader = cmd.ExecuteReader();
            reader.Read();
            int db = Convert.ToInt32(reader["id"]);
            SQLiteConnection con = new SQLiteConnection("Data Source =" + dbpath);
            con.Open();
            cmd = new SQLiteCommand("SELECT * FROM Groups", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmd = new SQLiteCommand("INSERT INTO groups (`group`, `db`) VALUES (@group, @db)", Gib.con);
                cmd.Parameters.AddWithValue("@group", reader["group"].ToString());
                cmd.Parameters.AddWithValue("@db", db);
                cmd.ExecuteNonQuery();
            }
            cmd = new SQLiteCommand("SELECT * FROM Words", con);
            reader = cmd.ExecuteReader();
            SQLiteDataReader rtmp;
            int tmp;
            while (reader.Read())
            {
                cmd = new SQLiteCommand("SELECT `id` FROM groups WHERE `group`=@group AND `db`=@db", Gib.con);
                cmd.Parameters.AddWithValue("@group", reader["group"].ToString());
                cmd.Parameters.AddWithValue("@db", db);
                rtmp = cmd.ExecuteReader();
                rtmp.Read();
                tmp = Convert.ToInt32(rtmp["id"]);

                cmd = new SQLiteCommand(strSQLInsert, Gib.con);
                cmd.Parameters.AddWithValue("@word", reader["word"].ToString());
                cmd.Parameters.AddWithValue("@trans", reader["explain"].ToString());
                cmd.Parameters.AddWithValue("@group", tmp);
                cmd.Parameters.AddWithValue("@state", 0);
                cmd.Parameters.AddWithValue("@gamestate", 0);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            try { File.Delete(dbpath); } catch { }
            FrmMain frm = (FrmMain)this.Owner;
            frm.refreshDBList();
            this.Close();
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            Import();
        }
    }
}