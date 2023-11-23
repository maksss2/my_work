using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private bool bekon = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {//движение картинки
            
            pct.Left = pct.Left + 20;
            if (pct.Left + pct.Width + 20 > this.ClientSize.Width)
            {
                tmr.Enabled = false;
            }
            else
            {
                pct.Left += 20;
            }

        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(bekon)
            {
                tmr.Enabled = true;
                tmr.Interval = 50;
                bekon = false;
                btnStart.Text = "Stop";
            }
            else
            {
                tmr.Enabled = false;
                bekon=true;
                btnStart.Text = "Start";
            }
  
         
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pct.Left = pct.Left - 560;
            if (pct.Left + pct.Width - 560 < this.ClientSize.Width)
            {
                tmr.Enabled = false;
            }
            else
            {
                pct.Left -= 560;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
