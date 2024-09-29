using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __lab14
{
    internal class Methods
    {
        SearchMethods search = new SearchMethods();
        public void LineMethod(RichTextBox targetText, short[] lineArray)
        {
            if (!string.IsNullOrEmpty(targetText.Text))
            {
                try
                {
                    short target = byte.Parse(targetText.Text.Trim());
                    short index = search.SearchNumber(lineArray, target);
                    if (index != -1)
                    {
                        MessageBox.Show($"Число {target} найдено на позиции {index}");
                    }
                    else
                    {
                        MessageBox.Show($"Число {target} не найдено");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("В поле поиска недопустимые символы!", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Поле поиска не заполнено");
        }
        public void BinaryMethod(RichTextBox targetText, RichTextBox arrayText, short[] lineArray)
        {
            if (!string.IsNullOrEmpty(targetText.Text))
            {
                try
                {
                    short target = short.Parse(targetText.Text.Trim());

                    // Сортируем массив перед поиском
                    Array.Sort(lineArray);

                    // Выводим отсортированный массив в текстовое поле для отладки
                    arrayText.Clear();
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        arrayText.AppendText($"Array[{i}]: {lineArray[i]}\n");
                    }

                    short index = search.BinarySearch(lineArray, target, 0, (short)(lineArray.Length - 1));

                    if (index != -1)
                    {
                        MessageBox.Show($"Число {target} найдено на позиции {index}");
                    }
                    else
                    {
                        MessageBox.Show($"Число {target} не найдено");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("В поле поиска должны быть только цифры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле поиска не заполнено");
            }
        }
        public void BubbleSort(RichTextBox arrayText, short[] newArray)
        {

            // Сортируем массив и сохраняем его в новый
            short[] sortedArray = search.BubbleSearch(newArray);

            // Выводим отсортированный массив в текстовое поле для отладки
            arrayText.Clear();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                arrayText.AppendText($"Array[{i}]: {sortedArray[i]} \n");
            }
        }
        public void InsertSort(RichTextBox arrayText, short[] newArray) {
            short[] sortedArray = search.InsertionSort(newArray);
            arrayText.Clear();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                arrayText.AppendText($"Array[{i}]: {sortedArray[i]} \n");
            }
        }
        public void SelectSort(RichTextBox arrayText, short[] newArray) 
        {
            short[] sortedArray = search.SelectionSort(newArray);
            // Выводим отсортированный массив в текстовое поле для отладки
            arrayText.Clear();
            for (int i = 0; i < sortedArray.Length; i++)
            {
                arrayText.AppendText($"Array[{i}]: {sortedArray[i]} \n");
            }
        }
    }
}
