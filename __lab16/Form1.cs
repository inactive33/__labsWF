using System;
using System.Windows.Forms;

namespace __lab16
{
    public partial class Form1 : Form
    {
        // Ускорение свободного падения
        const float g = 9.81f;
        public Form1()
        {
            InitializeComponent();
        }
        // Метод для расчета времени падения
        private float CalculateFallTime(float height)
        {
            return (float)Math.Sqrt(2 * height / g);
        }
        // Метод для расчета скорости в момент удара о землю
        private float CalculateVelocity(float height)
        {
            return (float)Math.Sqrt(2 * g * height);
        }
        // Метод для расчета высоты тела в любой момент времени
        private float CalculateHeight(float height, float time)
        {
            // Рассчитаем время полного падения
            float fallTime = (float)Math.Sqrt(2 * height / g);
            if (time >= fallTime)
            {
                return 0;
            }

            float heightAtTime = height - 0.5f * g * time * time;

            // Возвращаем высоту (но не ниже 0)
            return heightAtTime > 0 ? heightAtTime : 0;
        }
        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            float height;
            if (!float.TryParse(rTxtBox_height.Text, out height) || height <= 0) 
            {
                MessageBox.Show("Введите корректную высоту.");
                return;
            }
            float time;
            if (!float.TryParse(rTxtBox_time.Text, out time) || time < 0) {
                MessageBox.Show("Введите корректное время.");
                return;
            }

            float fallTime = CalculateFallTime(height);
            float velocity = CalculateVelocity(height);
            float currentHeight = CalculateHeight(height, time);

            rTxtBox_Output.Text = $"Время падения: {fallTime:F2} сек" +
                $"\nСкорость при ударе: {velocity:F2} м/c" +
                $"\nТекущая высота на момент времени {time:F2} сек: {currentHeight:F2} м";
        }
    }
}
