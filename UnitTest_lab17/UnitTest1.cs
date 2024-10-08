using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using __lab17;
namespace UnitTest_lab17
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateStudentAverages_CorrectlyCalculatesAverages()
        {
            // Arrange

            var student = new List<Students>  // Создаем список студентов
            {
                new Students("Иванов", new Dictionary<string, int> { { "Математика", 5 }, { "Физика", 4 }, { "Химия", 3 } }),
                new Students("Петров", new Dictionary<string, int> { { "Математика", 3 }, { "Физика", 4 }, { "Химия", 4 } })
            };

            var calculate = new StudentAverageModule();
            // Act
            calculate.CalculateStudentAverages(student);

            // Assert
            Assert.AreEqual(4.0, student[0].AverageGrade);  // Проверка среднего балла первого студента
            Assert.AreEqual(3.67, Math.Round(student[1].AverageGrade, 2));  // Проверка среднего балла второго студента
        }
    }
}
