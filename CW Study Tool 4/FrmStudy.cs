using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Speech.Synthesis;
using System.Threading;

namespace CW_Study_Tool_4
{
    public partial class FrmStudy : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmStudy()
        {
            InitializeComponent();
        }

        private List<Gib.Word> words = new List<Gib.Word>();
        private string originTitle = "";
        private int cur = 0, wordCountThisRound = 0;

        Thread tsp;
        SpeechSynthesizer spr = new SpeechSynthesizer();

        private void FrmStudy_Load(object sender, EventArgs e)
        {
            pnMain.BackColor = Color.White;

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group", Gib.con);
            cmd.Parameters.AddWithValue("@group", Gib.curGroup);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Gib.Word item = new Gib.Word();
                item.id = Convert.ToInt32(reader["id"]);
                item.word = reader["word"].ToString();
                item.trans = reader["trans"].ToString();
                item.state = Convert.ToInt32(reader["state"]);
                words.Add(item);
            }
            refreshState();
        }
        
        private void ReadWord()
        {
            try
            {
                if (File.Exists("C:\\ProgramData\\CW Soft\\Speech\\" + tbWord.Text.Trim() + ".mp3"))
                    Player.URL = "C:\\ProgramData\\CW Soft\\Speech\\" + tbWord.Text.Trim() + ".mp3";
                else
                    spr.Speak(tbWord.Text);
            }
            catch { }
        }
     

        int goodCount(bool countAll)
        {
            int count = 0, i;
            if (countAll)
            {
                for (i = 0; i < words.Count; ++i)
                    if (words[i].state == 1)
                        ++count;
            }
            else
            {
                for (i = 0; i <= cur; ++i)
                    if (words[i].state == 1)
                        ++count;
            }
            return count;
        }

        int badCount()
        {
            int count = 0, i;
            for (i = 0; i < words.Count; ++i)
                if (words[cur].state == 3)
                    ++count;
            return count;
        }

        void refreshState()
        {
            if (Gib.studymode == 0)
                this.Text = originTitle + " ( " + (cur + 1) + " / " + words.Count + " )";
            else
                this.Text = originTitle + " ( " + goodCount(false) + " / " + wordCountThisRound + " )";
            tbWord.Text = words[cur].word;
            replay();
            btnGood.Checked = (words[cur].state == 1);
            btnBad.Checked = (words[cur].state == 2);
            if (Gib.studymode == 0)
            {
                btnPrevious.Enabled = (cur > -1);
                btnNext.Enabled = (cur < words.Count);
            }
            else
            {
                btnPrevious.Enabled = btnNext.Enabled = false;
                for (int i = cur - 1; i >= 0; --i)
                    if (words[i].state == 2)
                    {
                        btnPrevious.Enabled = true;
                        break;
                    }
                for (int i = cur + 1; i < words.Count; ++i)
                    if (words[i].state == 2)
                    {
                        btnNext.Enabled = true;
                        break;
                    }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Gib.studymode == 0)
                --cur;
            else
                for (int i = cur - 1; i >= 0; --i)
                    if (words[i].state == 2)
                    {
                        cur = i;
                        break;
                    }
            refreshState();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (Gib.studymode == 0)
                --cur;
            else
                for (int i = cur - 1; i >= 0; --i)
                    if (words[i].state == 2)
                    {
                        cur = i;
                        break;
                    }
            refreshState();
        }

        void updateRemState(int state)
        {
            btnGood.Checked = (state == 1);
            btnBad.Checked = (state == 2);
            SQLiteCommand cmd = new SQLiteCommand("UPDATE words SET `state`=@state WHERE `id`=@id", Gib.con);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@id", words[cur].id);
            cmd.ExecuteNonQuery();
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            if (!btnBad.Checked)
                updateRemState(2);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            if (!btnGood.Checked)
                updateRemState(1);
        }

        void replay()
        {
            try { tsp.Abort(); } catch { }
            //try
            //{
                tsp = new Thread(ReadWord) { IsBackground = true, Name = "tsp", Priority = ThreadPriority.Highest };
                tsp.Start();
            //} catch { }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            replay();
        }

        private void ShowTraslation_Click(object sender, EventArgs e)
        {
            tbTrans.Text = words[cur].trans;
        }
    }
}
