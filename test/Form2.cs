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

       private void btnSave_Click(object sender, EventArgs e)
        {
            {
                // Создание диалогового окна для сохранения файла
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"; // Установка фильтра
                // Отображение диалогового окна и ожидание выбора файла пользователем
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
            string fileName = txt.Text.Trim(); // Trim to remove leading and trailing whitespaces

            if (!string.IsNullOrEmpty(fileName))
            {
                lstFromfile.Items.Clear(); // Clear items in the other ListBox

                // Use FileStream and BinaryReader to read from the file
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (br.PeekChar() != -1) // While there are characters in the file
                    {
                        lstFromfile.Items.Add(br.ReadString()); // Add each line from the file to ListBox
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt.Text); // Добавление текста из TextBox в ListBox
            txt.Clear(); // Очистка TextBox после добавления
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}