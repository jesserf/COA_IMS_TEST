using Guna.UI.WinForms;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Notice.Warning.Types;

namespace COA_IMS.Screens
{
    public partial class Splash_Screen : Form
    {

        public string data;
        public int length = 0;

        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void Splash_Screen_Load(object sender, EventArgs e)
        {
            data = label1.Text;
            label1.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (length < data.Length)
            {
                label1.Text = label1.Text + data.ElementAt(length);
                length++;
            }
            else
            {
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //    gunaProgressBar1.Increment(5);
            //    if (gunaProgressBar1.Value == 100)
            //    {
            //        timer1.Enabled = false;
            //        login log = new login();
            //        log.Show();
            //        this.Hide();
            //    }
        }
    }
    }

