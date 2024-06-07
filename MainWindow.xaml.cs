//Rafael Rivera Harrison
//6/1/2024
//Assignment - ListView ( and all other skills )
//CSI122 002 13635
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment__ListView__and_all_other_Skills_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> studentGradeAverage = new List<Student>();//this is the list storing the info and refrencing the fields from the student class
        public MainWindow()
        {
            InitializeComponent();//This is refrencing the info template that was made in the student class,it must be entered in this specific manner else the information will not run as required
            studentGradeAverage.Add(new Student("Jared", 76, 83));
            studentGradeAverage.Add(new Student("Willaim",98,75));
            studentGradeAverage.Add(new Student("DeShawn", 87, 51));
            studentGradeAverage.Add(new Student("Reggie", 87, 51));
            studentGradeAverage.Add(new Student("Dawson", 87, 51));

            UpdateListView();
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            string scholarName = studentName.Text;
            if(string.IsNullOrEmpty(scholarName) )
            {
                MessageBox.Show("Student name cannot be empty.");//The purpsose of this message is to inform the user the text box is empty
                return;//on detecting the box is empty it will trigger this return leaving the scope of thios ocode block
                if (double.TryParse(firstGrade.Text, out double grade1) && double.TryParse(secondGrade.Text, out double grade2))
                {
                    if (grade1 < 0 || grade1 > 100 || grade2 < 0 || grade2 > 100)
                    {
                        MessageBox.Show("Grades must be between 0 and 100.");
                        return;
                    }

                    Student newStudent = new Student(Name, grade1, grade2);
                    studentGradeAverage.Add(newStudent);
                    UpdateListView();
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers for grades.");
                }
            }

            //studentGradeTotal
        }
      

        private void editSelectedStudent_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItem is Student selectedStudent)
            {
                string name = studentName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Student name cannot be empty.");
                    return;
                }

                if (double.TryParse(firstGrade.Text, out double grade1) && double.TryParse(secondGrade.Text, out double grade2))
                {
                    if (grade1 < 0 || grade1 > 100 || grade2 < 0 || grade2 > 100)
                    {
                        MessageBox.Show("Grades must be between 0 and 100.");
                        return;
                    }

                    selectedStudent.Name1 = name;
                    selectedStudent.Grade11 = grade1;
                    selectedStudent.Grade21 = grade2;
                    UpdateListView();
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers for grades.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to edit.");
            }
        }

        private void deleteSelectedStudent_Click(object sender, RoutedEventArgs e)
        {
            if (ListView.SelectedItem is Student selectedStudent)
            {
                studentGradeAverage.Remove(selectedStudent);
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void UpdateListView()
        {
            ListView.Items.Clear();
            foreach (Student student in studentGradeAverage)
            {
                ListView.Items.Add(student);
            }

            // Ensure at least five students are displayed
            while (ListView.Items.Count < 5)
            {
                ListView.Items.Add(new Student("Placeholder", 0, 0));
            }
        }
    }
}