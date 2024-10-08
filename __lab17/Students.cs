using System.Collections.Generic;

namespace __lab17
{
    public class Students
    {
        public string Name { get; set; }
        public Dictionary<string, int> Grades { get; set; }
        public double AverageGrade;
        public Students(string name, Dictionary<string, int> grades)
        {
            Name = name;
            Grades = grades;
            AverageGrade = 0.0;
        }
    }
}
