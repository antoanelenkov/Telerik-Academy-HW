namespace StudentSystem.ConsoleApp
{
    using StudentSystem.Data;
    using Models;
    using System.Linq;
    using System;

    class EntryPoint
    {
        static void Main()
        {
            var db = new StudentSystemDbContext();

            var student = new Student() { Name = "Test" };
            db.Students.Add(student);

            var courseEntry = db.Courses.FirstOrDefault();
            courseEntry.Students.Add(student);

            db.SaveChanges();
        }
    }
}
