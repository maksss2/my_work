using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        Random random = new Random();
        List<string> icons = new List<string>()
        {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };
        
        public Form1()
        {
            InitializeComponent();
            AssingIconsToSquares();
            
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
                    iconLabel1.ForeColor = iconLabel1.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }


        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                clickedLabel.ForeColor == Color.Black;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
