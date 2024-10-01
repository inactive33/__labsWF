using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace __lab15
{
    public partial class FormMain : Form
    {
        private static readonly Random random = new Random();
        public FormMain()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton1_CheckedChanged);
        }


        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                rTextBox_Output.Clear();
                int result = GenerateRandomNumber(Int32.Parse(rTextBox_minValue.Text), Int32.Parse(rTextBox_maxValue.Text));
                rTextBox_Output.Text = result.ToString();
            }
            else if (radioButton2.Checked) {
                rTextBox_Output.Clear();
                string randomString = GenerateRandomString(Int32.Parse(rTxtBox_length.Text));
                rTextBox_Output.Text = randomString.ToString();
            }
        }

        private static int GenerateRandomNumber(int minValue, int maxValue) 
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException("minValue должен быть меньше или равно maxValue");

            byte[] randomBytes = new byte[maxValue + 1];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            // Преобразуем случайные байты в положительное целое число
            int randomInt = Math.Abs(BitConverter.ToInt32(randomBytes, 0));

            return (randomInt % (maxValue - minValue + 1)) + minValue;
        }

        // Метод для генерации случайного символа
        public char GenerateRandomCharacter()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int randomIndex = random.Next(chars.Length); // Генерация случайного индекса
            return chars[randomIndex]; // Возвращаем случайный символ
        }

        // Метод для генерации случайной символьной последовательности
        public string GenerateRandomString(int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(GenerateRandomCharacter()); // Добавляем случайные символы в строку
            }
            return result.ToString();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lbl_MinValue.Visible = true;
                lbl_MaxValue.Visible = true;
                rTextBox_minValue.Visible = true;
                rTextBox_maxValue.Visible = true;
                rTxtBox_length.Visible = false;
                lbl_length.Visible = false;
            }
            else if (radioButton2.Checked)
            {
                lbl_MinValue.Visible = false;
                lbl_MaxValue.Visible = false;
                rTxtBox_length.Visible = true;
                rTextBox_minValue.Visible = false;
                rTextBox_maxValue.Visible = false;
                lbl_length.Visible = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}
