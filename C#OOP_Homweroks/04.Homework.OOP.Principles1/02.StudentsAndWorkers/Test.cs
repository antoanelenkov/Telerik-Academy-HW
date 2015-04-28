using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Test
    {
        static void Main(string[] args)
        {
            //Initialize some students
            var stud1 = new Student("Antoan", "Elenkov", 9);
            var stud2 = new Student("Georgi", "Ivanov", 8);
            var stud3 = new Student("PEtar", "Petrov", 12);
            var stud4 = new Student("Angel", "Angelov", 10);
            var stud5 = new Student("Ivan", "Nasran", 7);
            var stud6 = new Student("Dqdo", "Mraz", 9);
            var stud7 = new Student("Super", "Man", 8);
            var stud8 = new Student("Jelezniqt", "Chovek", 12);
            var stud9 = new Student("Telerik", "Ninja", 10);
            var stud10 = new Student("Daffy", "Duck", 7);

            //Initialize some workers
            var worker1 = new Worker("Gosho", "Zidarov", 1100, 40);
            var worker2 = new Worker("Petio", "Iordanov", 1200, 40);
            var worker3 = new Worker("Dqdo", "Koleda", 1500, 30);
            var worker4 = new Worker("Bai", "Ivan", 1500, 40);
            var worker5 = new Worker("Bai", "Kolio", 2500, 20);
            var worker6 = new Worker("Baba", "Koleda", 3000, 60);
            var worker7 = new Worker("Zidar", "Mazachov", 1020, 50);
            var worker8 = new Worker("Maistor", "Pesho", 1200, 25);
            var worker9 = new Worker("Master", "Petrov", 1020, 35.5f);
            var worker10 = new Worker("Number", "One", 1500, 28);

            //List of students
            var listOfStudents = new List<Student>();
            listOfStudents.Add(stud1);
            listOfStudents.Add(stud2);
            listOfStudents.Add(stud3);
            listOfStudents.Add(stud4);
            listOfStudents.Add(stud5);
            listOfStudents.Add(stud6);
            listOfStudents.Add(stud7);
            listOfStudents.Add(stud8);
            listOfStudents.Add(stud9);
            listOfStudents.Add(stud10);

            //The students ordered by grade in ascending order
            var orderByGrade = listOfStudents.OrderBy(x => x.Grade)
                .Select(x=>new{x.FirstName,x.LastName,x.Grade});
            Console.WriteLine("The students ordered by grade in ascending order:");
            Console.WriteLine(String.Join(Environment.NewLine,orderByGrade));
            Console.WriteLine();

            //List of workers
            var listOfWorkers= new List<Worker>();
            listOfWorkers.Add(worker1);
            listOfWorkers.Add(worker2);
            listOfWorkers.Add(worker3);
            listOfWorkers.Add(worker4);
            listOfWorkers.Add(worker5);
            listOfWorkers.Add(worker6);
            listOfWorkers.Add(worker7);
            listOfWorkers.Add(worker8);
            listOfWorkers.Add(worker9);
            listOfWorkers.Add(worker10);

            //The workers ordered by wage perh hour in descending order
            var orderByWage = listOfWorkers.OrderByDescending(x => x.CalculateMoneyPerHour())
                .Select(x => new { x.FirstName, x.LastName, wage = x.CalculateMoneyPerHour() });
            Console.WriteLine("The workers ordered by wage perh hour in descending order:");
            Console.WriteLine(String.Join(Environment.NewLine, orderByWage));
            Console.WriteLine();

            //The workers and students ordered by first and last name
            var orderAllByFirstAndLastName = listOfWorkers.Cast<Human>()
                .Union(listOfStudents.Cast<Human>())
                .OrderBy(x=>x.LastName)
                .OrderBy(x=>x.FirstName)
                .Select(x=>new{x.FirstName,x.LastName});
            Console.WriteLine("The workers and students ordered by first and last name:");
            Console.WriteLine(String.Join(Environment.NewLine, orderAllByFirstAndLastName));
        }
    }
}
