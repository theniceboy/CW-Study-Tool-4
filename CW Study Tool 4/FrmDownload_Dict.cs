using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Net;

namespace CW_Study_Tool_4 {
    public partial class FrmDownload_Dict : DevComponents.DotNetBar.Metro.MetroForm {
        public FrmDownload_Dict() {
            InitializeComponent();
        }

        private void FrmDownload_Dict_Load(object sender, EventArgs e) {
            if (MessageBox.Show(this,
                "CW Study Tool is going to download the required dictionary from the internet. Do you want to continue?",
                "CW Study Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                this.Close();
                return;
            }
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri("http://7xnkmd.dl1.z0.glb.clouddn.com/ConciseOxfordEnglishChineseDictionary.db"), Gib.hostpath + "\\ConciseOxfordEnglishChineseDictionary.db");
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            progress.Value = e.ProgressPercentage;
            lbProgress.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            MessageBox.Show("Download completed!");
            FrmAddWord_Batch frm = (FrmAddWord_Batch) this.Owner;
            frm.dict_English_Chinese_complete();
            this.Close();
        }
    }
}