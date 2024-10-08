using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace __lab17
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Инкрементная интеграция модулей
        readonly DataInputModule inputModule = new DataInputModule();
        readonly SubjectAverageModule subjectAverageModule = new SubjectAverageModule();
        readonly StudentAverageModule studentAverageModule = new StudentAverageModule();
        readonly SortingModule sortingModule = new SortingModule();
        readonly OutputModule outputModule = new OutputModule();
        private void Btn_GoOutput_Click(object sender, EventArgs e)
        {
            rTxtBox_AverageStudent.Clear();
            rTxtBox_OutputBestStudents.Clear();
            rTxtBox_OutputReakStudents.Clear();
            // Ввод данных
            List<Students> students = inputModule.InputStudentData();
            // Вычисление средних баллов по предметам
            subjectAverageModule.CalculateSubjectAverages(students, rTxtBox_AverageStudent);

            // Вычисление средних баллов учеников
            studentAverageModule.CalculateStudentAverages(students);

            // Сортировка учеников по средним баллам
            sortingModule.SortStudentsByAverageGrade(students);

            // Вывод результатов
            outputModule.OutputResults(students, rTxtBox_OutputBestStudents, rTxtBox_OutputReakStudents);
        }
    }
}
