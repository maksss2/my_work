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
        private double precision;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            int counter = 0;
            double sum = 0;
            double summad = 0.0;
            double x;

          do
            { 
                counter++;
                if(double.TryParse(txtX.Text, out x) ){
                    summad = double.Parse(txtX.Text) / counter;
                }
                sum += summad;
            } while (Math.Abs(summad) > double.Parse(txtPrecision.Text));

            //вывод рузультата
            lblResult.Text = "сумма = " + sum + ", количесвто = " + counter;


            //я хз чо тут не так



        }
        
    }
}
