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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {//движение картинки
            pct.Left = pct.Left + 20;
            
                 }
        
        private void btnStart_Click(object sender, EventArgs e)
        {/* по сути тут можно сделать так
         тчо бы картинка останавливалсь по истеченю времент
         взять что то из прошлой работы*/
            tmr.Enabled = true;
            tmr.Interval = 50;
            Console.WriteLine(tmr);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
