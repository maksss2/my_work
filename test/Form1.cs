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

        private void Form1_Load(object sender, EventArgs e)
        {
            file1.Filter = "(*.jpg)|*.jpg"; //фильтр что бы открывались только жпег
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string fname;
            file1.ShowDialog();
            fname = file1.FileName;
            pct.Image = Image.FromFile(fname);

            pct.Load(file1.FileName);
            textBox1.Text = file1.FileName; // Выводится полное имя файла в TextBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.Show(); 

            
        }
    }
}
