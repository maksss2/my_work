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

        int addend1;
        int addend2;
        int minued;
        int subtrahend;
        int multiplicand;
        int multiplier;
        int dividend;
        int divisor;
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private bool CheckTheAnswer() //проверка
        {
            bool isCorrect = (addend1 + addend2 == sum.Value)
                && (minued - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value);
            Console.WriteLine("addition result: " + (addend1 + addend2 == sum.Value));
            Console.WriteLine("subtraction result: " + (minued - subtrahend == difference.Value));
            Console.WriteLine("multiplication result: " + (multiplicand * multiplier == product.Value));
            Console.WriteLine("division result: " + (dividend / divisor == quotient.Value));
            return isCorrect;
        }
        public void StartTheQuiz() //случайные циферы
        {
            Random randomizer = new Random();
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
            minued = randomizer.Next(1, 101);
            minusLeftLabel.Text = minued.ToString();
            subtrahend = randomizer.Next(1, minued);
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
            timeLeft = 30;
            timeLabel.Text = "30 секунд";
            Console.WriteLine("addend1 = " + addend1);
            Console.WriteLine("addend2 = " + addend2);
            Console.WriteLine("minued = " + minued);
            Console.WriteLine("subtrahend = " + subtrahend);
            Console.WriteLine("multiplicand = " + multiplicand);
            Console.WriteLine("multiplier = " + multiplier);
            Console.WriteLine("dividend = " + dividend);
            Console.WriteLine("divisor = " + divisor);
            timer1.Start();

        }
        private bool isTimerStopped = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 6)
            {
                timeLabel.BackColor = Color.Red;
            }
            if (CheckTheAnswer())
            {
                if (!isTimerStopped)
                {
                    isTimerStopped = true;
                    timer1.Stop();
                    MessageBox.Show("Все верно, пойдешь в артеллеристы",
                        "Страна гордится тобой");
                    startButton.Enabled = true;
                }
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " секунд";
            }
            else
            
            {
                if (!isTimerStopped)
                {
                    isTimerStopped = true;
                    timer1.Stop();
                    timeLabel.Text = "000000";
                    MessageBox.Show("bruh...", "канец");
                    sum.Value = addend1 + addend2;
                    difference.Value = minued - subtrahend;
                    product.Value = multiplicand * multiplier;
                    quotient.Value = dividend / divisor;
                    startButton.Enabled = true;
                }
                
            }
        }
        
    }
}