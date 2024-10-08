using System.Collections.Generic;

namespace __lab17
{
    public class DataInputModule
    {
        public List<Students> InputStudentData()
        {
            List<Students> students = new List<Students>
            {
                new Students("Иванов", new Dictionary<string, int> { { "Математика", 5 }, { "Физика",5 }, { "Химия", 4 } }),
                new Students("Петров", new Dictionary<string, int> { { "Математика", 4 }, { "Физика", 5 }, { "Химия", 3} }),
                new Students("Сидоров", new Dictionary<string, int> { { "Математика", 2}, { "Физика", 5}, { "Химия", 3 } }),
                new Students("Кузнецов", new Dictionary<string, int> { { "Математика", 5 }, { "Физика", 3 }, { "Химия", 3 } }),
                new Students("Смирнов", new Dictionary<string, int> { { "Математика", 4}, { "Физика", 4}, { "Химия", 4 } })
            };
            return students;
        }
    }
}
