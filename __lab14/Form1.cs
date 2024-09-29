using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __lab14
{
    public partial class FormMain : Form
    {
        Random random = new Random();
        Methods methods = new Methods();
        public short[] lineArray;
        public short[] arrayForBubbleSort;
        public short minValueSize = 5;
        public short maxValueSize = 25;
        public short minValueArray = 0;
        public short maxValueArray = 1000;
        public FormMain()
        {
            InitializeComponent();
        }
        private void Btn_CreateLineArray_Click(object sender, EventArgs e)
        {
            lineArray = new short[random.Next(minValueSize, maxValueSize)];

            richTxtBox_LineArray.Clear();
            InputArray(lineArray, richTxtBox_LineArray);

        }
        private void Btn_FindNumber_Click(object sender, EventArgs e)
        {
            if (rdButton_Line.Checked)
            {
                methods.LineMethod(richTxtBox_target, lineArray);
            }
            else if (rdButton_Binary.Checked)
            {
                methods.BinaryMethod(richTxtBox_target, richTxtBox_LineArray, lineArray);
            }
        }
        private void InputArray(short[] array, RichTextBox txtBoxOutput)
        {
            // Генерация чисел массива для линейного и бинарного
            for (short i = 0; i < array.Length; i++)
            {
                array[i] = (short)random.Next(minValueArray, maxValueArray);
                txtBoxOutput.AppendText($"Array[{i}]: {array[i]} \n");
            }
        }

        private void Btn_GenerateArray_Click(object sender, EventArgs e)
        {
            arrayForBubbleSort = new short[random.Next(minValueSize, maxValueSize)];

            RtxtBox_ArrayText.Clear();
            InputArray(arrayForBubbleSort, RtxtBox_ArrayText);
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            if (radioButton_bubbleSort.Checked)
            {
                methods.BubbleSort(RtxtBox_ArrayText, arrayForBubbleSort);
            }
            else if (radioButton_InsertSort.Checked) {
                methods.InsertSort(RtxtBox_ArrayText, arrayForBubbleSort);
            } else if (radioButton_ChooseSort.Checked) {
                methods.SelectSort(RtxtBox_ArrayText, arrayForBubbleSort);
            }

        }
    }
}
