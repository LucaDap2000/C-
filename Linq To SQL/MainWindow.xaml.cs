using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;

namespace Linq_To_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSQLDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Linq_To_SQL.Properties.Settings.PANJUTORIALSDBConnectionString"].ConnectionString;
            dataContext = new LinqToSQLDataClassesDataContext(connectionString);

            // InsertUniversities();
            // InsertStudents();
            // InsertLectures();
            // InsertStudentLectureAssociations();
            // GetUniversityOfPeter();
            // GetLecturesFromPeter();
            // GetAllStudentsFromOxford();
            // GetAllUniversitiesWithTransgenderStudents();
            // GetAllLecturesFromYork();
            // UpdatePeter();
            DeleteChris();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University oxford = new University();
            oxford.Name = "Oxford";
            dataContext.Universities.InsertOnSubmit(oxford);

            University york = new University();
            york.Name = "York";
            dataContext.Universities.InsertOnSubmit(york);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University oxford = dataContext.Universities.First(un => un.Name.Equals("Oxford"));
            // Returning an object of type University ^^

            University york = dataContext.Universities.First(un => un.Name.Equals("York"));
            // Returning an object of type University ^^

            // from university in dataContext.University where university == "Oxford" select university;
            // Returns a collection ^^

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Sophie", Gender = "Female", University = york });
            students.Add(new Student { Name = "Peter", Gender = "Male", University = york });
            students.Add(new Student { Name = "Jacqueline", Gender = "Female", University = oxford });
            students.Add(new Student { Name = "Chris", Gender = "Trans-gender", University = oxford });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Maths" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Sophie = dataContext.Students.First(st => st.Name.Equals("Sophie"));
            Student Peter = dataContext.Students.First(st => st.Name.Equals("Peter"));
            Student Jacqueline = dataContext.Students.First(st => st.Name.Equals("Jacqueline"));
            Student Chris = dataContext.Students.First(st => st.Name.Equals("Chris"));

            Lecture Maths = dataContext.Lectures.First(lc => lc.Name.Equals("Maths"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Sophie, Lecture = Maths });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Peter, Lecture = Maths });

            StudentLecture slPeter = new StudentLecture();
            slPeter.Student = Peter;
            slPeter.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slPeter);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jacqueline, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfPeter()
        {
            Student Peter = dataContext.Students.First(st => st.Name.Equals("Peter"));

            University PetersUniversity = Peter.University;

            List<University> universities = new List<University>();
            universities.Add(PetersUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromPeter()
        {
            Student Peter = dataContext.Students.First(st => st.Name.Equals("Peter"));

            var PetersLectures = from sl in Peter.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = PetersLectures;
        }

        public void GetAllStudentsFromOxford()
        {
            var studentsFromOxford = from student in dataContext.Students
                                     where student.University.Name == "Oxford"
                                     select student;

            MainDataGrid.ItemsSource = studentsFromOxford;
        }

        public void GetAllUniversitiesWithTransgenderStudents()
        {
            var transgenderUniversities = from student in dataContext.Students
                                          join university in dataContext.Universities
                                          on student.University equals university
                                          where student.Gender == "Trans-gender"
                                          select university;

            MainDataGrid.ItemsSource = transgenderUniversities;
        }

        public void GetAllLecturesFromYork()
        {
            var lecturesFromYork = from sl in dataContext.StudentLectures
                                   join student in dataContext.Students on sl.StudentId
                                   equals student.Id where student.University.Name == "York"
                                   select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromYork;
        }

        public void UpdatePeter()
        {
            Student Peter = dataContext.Students.FirstOrDefault(st => st.Name == "Peter");

            Peter.Name = "Pietro";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteChris()
        {
            Student Chris = dataContext.Students.FirstOrDefault(st => st.Name == "Chris");
            dataContext.Students.DeleteOnSubmit(Chris);
            dataContext.SubmitChanges();

            string connectionString = ConfigurationManager.ConnectionStrings["Linq_To_SQL.Properties.Settings.PANJUTORIALSDBConnectionString"].ConnectionString;

            LinqToSQLDataClassesDataContext db = new LinqToSQLDataClassesDataContext(connectionString);

            MainDataGrid.ItemsSource = dataContext.Students;
        }
    }
}
