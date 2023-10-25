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
        Random random = new Random();
            List<string> icons = new List<string>()
            {
"!", "!","N","N",",",",","k","k","b","b","v","v","w","z","z"
            //рандомайз иконок
            };
        
        public Form1()
        {
            InitializeComponent();
        }
       private void AssingIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel1 = control as Label;
                if (iconLabel1 != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel1.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
