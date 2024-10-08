using System.Collections.Generic;

namespace __lab17
{
    public class SortingModule
    {
        public void SortStudentsByAverageGrade(List<Students> students)
        {

            for (int i = 0; i < students.Count - 1; i++)
            {
                for (int j = 0; j < students.Count - i - 1; j++)
                {
                    if (students[j].AverageGrade < students[j + 1].AverageGrade)
                    {
                        (students[j + 1], students[j]) = (students[j], students[j + 1]);
                    }
                }
            }
        }
    }
}
