using System.Collections.Generic;

namespace __lab17
{
    public class StudentAverageModule
    {
        public void CalculateStudentAverages(List<Students> students)
        {
            foreach (var student in students)
            {
                int total = 0;
                foreach (var grade in student.Grades.Values)
                {
                    total += grade;
                }
                student.AverageGrade = (double)total / student.Grades.Count;
            }
        }
    }
}
