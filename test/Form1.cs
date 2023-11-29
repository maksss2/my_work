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

        }
        private int NumberSymbols(string stroka, char sembol)
        {
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == sembol)
                {
                    k += 1;
                }
            }
            return k;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //получаем входную строку из текстового поля
            string input = txtString.Text;
            //получаем символ из текстового поля и берем первый символ (если есть конечно)
            char symbol = textBox1.Text[0];
            //вызываем не аркадия паровозова конечно, но метод по подсчету количества заданного символа в строке
            int count = NumberSymbols(input, symbol);
            //вывод в textBox (такая панелька на форме)
            txtKolvo.Text = count.ToString();
            //даем переменную для сочетания "ма"
            int maCount = 0;
            //запускаем супер мега цикл, который проходит по каждому символу в строке, проверяя пары символов "м" и "а"
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'м' && input[i + 1] == 'а')
                {
                    maCount++;
                }
            }
            //выводим в textBox (такая панелька на форме)
            txtKolvoMA.Text = maCount.ToString(); 
        }
    }
}
