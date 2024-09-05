using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace __lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            richTxtBox_Email.TextChanged += new EventHandler(CheckEmptyText);
            richTxtBox_emailMessage.TextChanged += new EventHandler(CheckEmptyText);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = richTxtBox_Email.Text;
            string text = richTxtBox_emailMessage.Text;

            if (IsValidEmail(email))
            {
                saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    Title = "Сохранить email и сообщение",
                    DefaultExt = "txt",
                    FileName = "saved_email_message.txt"
                };

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SaveToFile(saveFileDialog1.FileName, email, text);
                        MessageBox.Show("Данные успешно сохранены в файл!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Введённый email некорректен. Пожалуйста, убедитесь, что email содержит символы '@' и '.', а также не содержит пробелов.", "Ошибка ввода", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SaveToFile(string filePath, string email, string message)
        {
            // Сохраняем email и сообщение в две строки
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(email);  
                writer.WriteLine(message);   
            }
        }
        private void OpenFile(string filePath) 
        {
            using (StreamReader reader = new StreamReader(filePath)) {
                string email = reader.ReadLine();
                string message = reader.ReadToEnd();

                richTxtBox_Email.Text = email;
                richTxtBox_emailMessage.Text = message;
            }

        }

        private void btn_OpenEmail_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog 
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                Title = "Открыть сохраненный файл"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OpenFile(openFileDialog1.FileName);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckEmptyText(object sender, EventArgs e)
        {
            string email = richTxtBox_Email.Text;
            string text = richTxtBox_emailMessage.Text;

            btnSave.Enabled = !string.IsNullOrWhiteSpace(email) && !string.IsNullOrEmpty(text);
        }
        private bool IsValidEmail(string email)
        {
           string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
           return Regex.IsMatch(email, emailPattern);
        }
    }
}
