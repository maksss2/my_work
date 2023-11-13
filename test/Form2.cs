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
    public partial class Form2 : Form
    {
        private bool isTimerRunning = false;

        public Form2()
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
                tmrSecundomer.Stop();
                isTimerRunning = false;
            }
            else
            {
                tmrSecundomer.Start();
                isTimerRunning = true;
            }
        }
    }

}
