using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace __lab17
{
    public class OutputModule
    {
        public void OutputResults(List<Students> students, RichTextBox outputBestStudentBox, RichTextBox outputReakStudentBox)
        {
            // Вывод трех лучших учеников
            for (int i = 0; i < Math.Min(3, students.Count); i++)
            {
                outputBestStudentBox.AppendText($"{students[i].Name} - Средний балл: {students[i].AverageGrade:F2}\n");
            }

            // Вывод слабых учеников
            for (int i = students.Count - 1; i >= Math.Max(0, students.Count - 3); i--)
            {
                outputReakStudentBox.AppendText($"{students[i].Name} - Средний балл: {students[i].AverageGrade:F2}\n");
            }

        }
    }
}
