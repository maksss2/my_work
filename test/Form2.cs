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
    public partial class Время : Form
    {
        private bool isTimerRunning = false;

        public Время()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            tmp += 1;
            txtSeconds.Text = tmp.ToString();

            int tmt = Int32.Parse(txtMinutes.Text);
            tmp += 60;
            txtMinutes.Text = tmt.ToString();


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                timer2.Stop();
                timer1.Stop();
                tmrSecundomer.Stop();
                isTimerRunning = false;
            }
            else
            {
                timer2.Start();
                timer1.Start();
                tmrSecundomer.Start();
                isTimerRunning = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tmt = Int32.Parse(txtMinutes.Text);
            tmt += 1;
            txtMinutes.Text = tmt.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = "Текущее время: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }

}
