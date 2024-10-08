using System.Collections.Generic;
using System.Windows.Forms;

namespace __lab17
{
    public class SubjectAverageModule
    {
        // Вычисление среднего балла по предмету
        public void CalculateSubjectAverages(List<Students> students, RichTextBox AverageStudentBox)
        {
            Dictionary<string, double> subjectAverages = new Dictionary<string, double>();
            Dictionary<string, int> subjectCount = new Dictionary<string, int>();

            foreach (var subject in students[0].Grades.Keys)
            {
                subjectAverages[subject] = 0;
                subjectCount[subject] = 0; // для подсчета количества учеников с оценкой по этому предмету
            }

            foreach (var student in students)
            {
                foreach (var subject in student.Grades.Keys)
                {
                    if (subjectAverages.ContainsKey(subject))
                    {
                        subjectAverages[subject] += student.Grades[subject];
                        subjectCount[subject]++;
                    }
                }
            }
            // Вычисляем средние значения
            foreach (var subject in subjectAverages.Keys)
            {
                double average = subjectAverages[subject] / subjectCount[subject];
                AverageStudentBox.AppendText($"Средний балл по '{subject}': {average:F2}\n");
            }
        }
    }
}
