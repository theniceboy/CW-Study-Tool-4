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
using MySql.Data.MySqlClient;

namespace CW_Study_Tool_4
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            String myInfo = "欢迎使用 ASP.NET MVC! ";

            ///////////////////获取MYSQ看数据返回值////////////////////////////  
            MySqlConnection myconn = null;
            MySqlCommand mycom = null;
            MySqlDataReader myrec = null;

            //连接字符串拼装  
            myconn = new MySqlConnection("Host = 127.0.0.1;Database = test;Username = root;Password = fulei");

            //连接  
            myconn.Open();

            if (myconn.State.ToString() == "Open")
            {
                MessageBox.Show("连接MYSQL成功");
            }
        }

        private void btnNewWordsWalkthough_Click(object sender, EventArgs e)
        {

        }

        private void btnMulltiLearn_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewWords_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiReview_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnWordList_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
