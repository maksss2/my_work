using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private int[] Arr = new int[10];

       private void ClearFields() //функция очистки полей
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            ClearFields();
            int n = 10;
            int a, b;
            if (int.TryParse(txtMin.Text, out a) && int.TryParse(txtMax.Text, out b))
            {
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    Arr[i] = r.Next(a, b);
                    lblArr.Text += Arr[i];
                    if (i != 0) lblArr.Text += ",";
                }
                btnSort.Enabled = true;
            }
            else //защита от дурачка
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа");
            }
        }


        private int MinNumber(int[] x, int m) 
        {
            int min = x[m];
            int MinN = m; // приводит к состоянию готовности минимальный элемент в оставшейся части массива
            for (int i = m; i < x.Length; i++) //Цикл определения минимального элемента в оставшейся части массива
            {
                if (x[i] < min) //Обновление минимального элемента и его индекса
                {
                    min = x[i];
                    MinN = i;
                }
            }
            return MinN; //Возвращаем индекс мин элемента
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for (int i = 0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i]; //Временная переменная
                Arr[i] = Arr[k]; // i заменяется на мин значение из предыдущего шага
                Arr[k] = t; // Значение из предыдущего шага заменятеся на значение из временной переменной
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1) { lblResult.Text += ","; } //Добавление запятой, если данный элемент не последний
            }
           btnSort.Enabled = false;
            

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
