using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_With_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We apply our Student-Structure to XML

            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Tony</Name>
                                <Age>21</Age>
                                <University>Cambridge</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carly</Name>
                                <Age>19</Age>
                                <University>Cambridge</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Rebecca</Name>
                                <Age>22</Age>
                                <University>York</University>
                                <Semester>10</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Durham</University>
                                <Semester>15</Semester>
                            </Student>
                        </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} in semester {3}", student.Name, student.Age, student.University, student.Semester);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} in semester {3}", student.Name, student.Age, student.University, student.Semester);
            }

            Console.ReadLine();
        }
    }
}
