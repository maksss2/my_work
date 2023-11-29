using System;
using System.IO;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txtFileName.Text);
            txtFileName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Создание  окна для сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Установка фильтра
                // Отображение диалогового окна 
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName; // Получить имя выбранного файла

                    if (!string.IsNullOrEmpty(fileName))
                    {
                        // Использование StreamWriter для записи текста в файл
                        using (StreamWriter writer = new StreamWriter(fileName))
                        {
                            foreach (string item in lst.Items) // Перебор элементов в ListBox
                            {
                                writer.WriteLine(item); // Запись каждого элемента в файл
                            }
                        }
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            {
                string fileName = txtFileName.Text; // Получение имени файла из текстового поля
                lstFromfile.Items.Clear(); // Очистка элементов в другом ListBox
                
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (br.PeekChar() != -1) 
                    {
                        lstFromfile.Items.Add(br.ReadString()); // Добавление каждой строки из файла в ListBox
                    }
                    br.Close();
                    fs.Close();
                }
            }
        }
    }
}
