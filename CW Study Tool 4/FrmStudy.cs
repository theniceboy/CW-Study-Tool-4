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
        private bool willFinish = false;
        List<int> stateList = new List<int>();
        private int round = 0, js = 1;

        Thread tsp;
        SpeechSynthesizer spr = new SpeechSynthesizer();

        private void FrmStudy_Load(object sender, EventArgs e)
        {
            pnMain.BackColor = Color.White;

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM words WHERE `group`=@group", Gib.con); // ORDER BY `word`
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
            wordCountThisRound = words.Count - goodCount(true);
            if (Gib.studymode == 1 && words[cur].state == 1)
            {
                --js;
                btnNext_Click(sender, e);
            }
            refreshGoodBadCount();

            stateList.Add(goodCount(true));
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
                if (words[i].state == 2)
                    ++count;
            return count;
        }

        void refreshState(bool doReplay = true)
        {
            if (Gib.studymode == 0)
                this.Text = originTitle + " ( " + (cur + 1) + " / " + words.Count + " )";
            else
                this.Text = originTitle + " ( " + js + " / " + wordCountThisRound + " )";
            tbWord.Text = words[cur].word;
            if (doReplay)
                replay();
            btnGood.Checked = (words[cur].state == 1);
            btnBad.Checked = (words[cur].state == 2);
            if (Gib.studymode == 0)
            {
                btnPrevious.Enabled = (cur > 0);
                willFinish = (cur == words.Count - 1);
            }
            else
            {
                btnPrevious.Enabled = false;
                willFinish = true;
                for (int i = cur - 1; i >= 0; --i)
                    if (words[i].state == 2)
                    {
                        btnPrevious.Enabled = true;
                        break;
                    }
                for (int i = cur + 1; i < words.Count; ++i)
                    if (words[i].state == 2)
                    {
                        willFinish = false;
                        break;
                    }
            }
            btnNext.Enabled = (btnGood.Checked || btnBad.Checked);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (!btnPrevious.Enabled)
                return;
            --js;
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
            if (!btnNext.Enabled)
                return;
            ++js;
            if (willFinish)
            {
                if (Gib.studymode == 0)
                    this.Close();
                else
                {
                    int badsum = badCount();
                    if (badsum > 0)
                    {
                        int tmp = goodCount(true) - stateList[round];
                        MessageBox.Show(this,
                            "You've learn " + tmp + " word" + (tmp > 1 ? "s" : "") + " in this round. Moving to round " +
                            (round + 2) + "!", "CW Study Tool");
                        stateList.Add(goodCount(true));
                        ++round;
                        wordCountThisRound = words.Count - goodCount(true);
                        cur = 0;
                        js = 1;
                        refreshState(false);
                        if (words[cur].state == 1)
                        {
                            --js;
                            btnNext_Click(sender, e);
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                return;
            }
            if (Gib.studymode == 0)
                ++cur;
            else
                for (int i = cur + 1; i < words.Count; ++i)
                    if (words[i].state == 2)
                    {
                        cur = i;
                        break;
                    }
            refreshState();
        }

        void refreshGoodBadCount()
        {
            btnGood.Text = " Remember\r\n( " + goodCount(true) + " )";
            btnBad.Text = " Forgot\r\n( " + badCount() + " )";
        }

        void updateRemState(int state)
        {
            btnGood.Checked = (state == 1);
            btnBad.Checked = (state == 2);
            SQLiteCommand cmd = new SQLiteCommand("UPDATE words SET `state`=@state WHERE `id`=@id", Gib.con);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@id", words[cur].id);
            cmd.ExecuteNonQuery();
            Gib.Word item = words[cur];
            item.state = state;
            words[cur] = item;
            refreshGoodBadCount();
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            if (!btnBad.Checked)
                updateRemState(2);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
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

        private void FrmStudy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain frm = (FrmMain) this.Owner;
            frm.refreshWords();
        }
        
        private void pnMain_BackColorChanged(object sender, EventArgs e)
        {
            pnMain.BackColor = Color.White;
        }

        private void btnWordList_Click(object sender, EventArgs e)
        {
            FrmWordList frm = new FrmWordList();
            frm.ShowDialog(this);
        }

        private void frmKeyDown(object sender, KeyEventArgs e)
        {
            if (sbUseShortcut.Value)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.G)
                    btnGood_Click(null, null);
                else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.B)
                    btnBad_Click(null, null);
                else if (e.KeyCode == Keys.Left)
                    btnPrevious_Click(null, null);
                else if (e.KeyCode == Keys.Right)
                    btnNext_Click(null, null);
                else if (e.Control || e.KeyCode == Keys.S)
                    ShowTraslation_Click(null, null);
                else if (e.Shift || e.KeyCode == Keys.R)
                    replay();
                else if (e.KeyCode == Keys.H) { }
            }
        }

        private void ShowTraslation_Click(object sender, EventArgs e)
        {
            tbTrans.Text = words[cur].trans;
        }
    }
}
