using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Test
    {
        static void Main(string[] args)
        {
            //Create some groups and students
            var listOfStudents = new List<Student>();
            var listOfGroups=new List<Group>();
            var orc = new Group(1, "Mathematics");
            var human = new Group(2, "Informatics");
            var zerg = new Group(3, "Physics");
            var stupids = new Group(3, "StupidDep");
            var masters = new Group(3, "MasterDep");
            listOfGroups.Add(orc);
            listOfGroups.Add(human);
            listOfGroups.Add(zerg);
            listOfStudents.Add(new Student("Antoan", "Elenkov", 14605, "(02)123654", "antoan@abv.bg", new List<byte>() { 6, 6, 6, 5, 4 }, orc.GroupNumber));
            listOfStudents.Add(new Student("Petar", "Angelov", 14606, "(034)31434", "petar@abv.bg", new List<byte>() { 6, 6 }, human.GroupNumber));
            listOfStudents.Add(new Student("Georgi", "Petrov", 14608, "(025)123654", "georgi@gmail.com", new List<byte>() { 6, 6, 2, 5, 5 }, human.GroupNumber));
            listOfStudents.Add(new Student("Martin", "Georgiev", 14611, "(02)12343654", "martin@yahoo.com", new List<byte>() { 6, 6, 6, 6, 6 }, zerg.GroupNumber));
            listOfStudents.Add(new Student("Elena", "Petrova", 14603, "(02)123343654", "elena@gmail.com", new List<byte>() { 2, 2, 2, 5, 4 }, orc.GroupNumber));

            //Select only the students that are from group number 2.Use LINQ query. Order the students by FirstName.
            //09.LINQ
            var studentsFromGroupNumber2LINQ =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            Console.WriteLine("09.LINQ \nOrdered by name in group number 2:");
            foreach (var item in studentsFromGroupNumber2LINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + ": " + item.GroupNumber);
            }
            //10.Extention methods.
            var studentsFromGroupNumber2 = listOfStudents.Where(x => x.GroupNumber == 2)
                                    .OrderBy(x => x.FirstName);
            Console.WriteLine("10.EXTENTION METHODS \nOrdered by name in group number 2:");
            foreach (var item in studentsFromGroupNumber2)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + ": " + item.GroupNumber);
            }

            //11.Extract all students that have email in abv.bg.
            var studentsEmailsList =
               from student in listOfStudents
               where student.Email.Contains("abv.bg")
               select student;
            Console.WriteLine("11. \nStudents who have email in abv.bg:");
            foreach (var item in studentsEmailsList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + ": " + item.Email);
            }

            //12.Extract all students with phones in Sofia.
            var studentsInSofia =
                from student in listOfStudents
                where student.Phone.Contains("(02)")
                select student;
            Console.WriteLine("12. \nStudents who have phone numbers in Sofia:");
            foreach (var item in studentsInSofia)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + ": " + item.Phone);
            }

            //13.Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            var greatStudents =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new { student.FirstName, student.LastName, marks = String.Join(", ", student.Marks) };
            Console.WriteLine("13. \nAll students with at least one excellent mark:");
            Console.WriteLine(String.Join(Environment.NewLine, greatStudents));

            //14.Write down a similar program that extracts the students with exactly two marks "2". Use extension methods.
            var studentsWithTwoMarks = listOfStudents.Where(x => x.Marks.Count == 2)
                .Select(x=>new{x.FirstName,x.LastName,marks=String.Join(", ",x.Marks)});
            Console.WriteLine("14. \nAll students with exactly 2 marks:");
            Console.WriteLine(String.Join(Environment.NewLine, studentsWithTwoMarks));//Method ToString() overrided

            //15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentsEnrolledIn2006 = listOfStudents.Where(x => (x.Fn - 6) == x.Fn / 100 * 100)
                .Select(x => new { x.FirstName, x.LastName, x.Fn}); ;
            Console.WriteLine("14. \nAll students who enrolled in 2006:");
            Console.WriteLine(String.Join(Environment.NewLine, studentsEnrolledIn2006));

            //16*.Extract all students from "Mathematics" department.
            var studentsFromMathDepLINQ =
                from student in listOfStudents
                join groups in listOfGroups on student.GroupNumber equals groups.GroupNumber into groupGroup
                from groups in groupGroup
                where groups.DepartmentName == "Mathematics"
                select new { student.FirstName, student.LastName, groups.DepartmentName };
            Console.WriteLine("16*.Lambda Expressions \nAll students who are in Mathematics department:");
            
            Console.WriteLine(String.Join(Environment.NewLine, studentsFromMathDepLINQ));
            //16*.LINQ.Extract all students from "Mathematics" department.
            var studentsFromMathDep = listOfStudents.
                Join(listOfGroups, student => student.GroupNumber, group => group.GroupNumber, (student, group) => new { student, group })
                .Where(x => x.group.DepartmentName == "Mathematics")
                .Select(d => new { d.student.FirstName,d.student.LastName,d.group.DepartmentName });
            Console.WriteLine("\n16*.LINQ \nAll students who are in Mathematics department:");
            Console.WriteLine(String.Join(Environment.NewLine, studentsFromMathDep));

            //18.LINQ.Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            var studentsByGroupLINQ =
                from student in listOfStudents
                orderby student.GroupNumber
                select new { student.FirstName, student.LastName, student.GroupNumber };
            Console.WriteLine("\n18.LINQ\n The students ordered by number of the groups:");
            Console.WriteLine(String.Join(Environment.NewLine, studentsByGroupLINQ));

            //18.Extention method.Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
            var studentsByGroupExt = listOfStudents.OrderBy(x => x.GroupNumber).Select(x => new { x.FirstName, x.LastName, x.GroupNumber });
            Console.WriteLine("\n18.EXTENTION METHODS\n The students ordered by number of the groups:");
            Console.WriteLine(String.Join(Environment.NewLine, studentsByGroupExt));





        }
    }
}
