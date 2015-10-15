using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentSystem.Data.Migrations
{
    public class DataSeeder
    {
        public static Random Rand = new Random();

        public List<Student> Students;

        public List<Course> Courses;

        public List<Homework> Homeworks;

        public Random randomGenerator;

        public DataSeeder()
        {
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
            this.Homeworks = new List<Homework>();
            this.randomGenerator = new Random();

            for (int i = 0; i < 100; i++)
            {
                var deadLine = new Homework() { Content = this.GetRandomName(), DeadLine = this.GerRandomDate() };

                this.Homeworks.Add(deadLine);
            }

            for (int i = 0; i < 100; i++)
            {
                var student = new Student() { Name = this.GetRandomName(), StudentId = GetRandomNumberInRange(0, 10), HomeWorks = this.Homeworks.Take(10).ToList()};

                this.Students.Add(student);
            }

            for (int i = 0; i < 100; i++)
            {
                var course = new Course() { Name = this.GetRandomName(), Description = this.GetRandomName(), Materials = this.GetRandomName(), Homeworks = this.Homeworks.Take(100).ToList(),Students=this.Students.Take(1).ToList()};

                this.Courses.Add(course);
            }
        }

        private int GetRandomNumberInRange(int bottom, int top)
        {
            return this.randomGenerator.Next(bottom, top);
        }

        private string GetRandomName()
        {
            var name = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                var charNumberInUTF = this.randomGenerator.Next(97, 122);

                name += (char)charNumberInUTF;
            }

            return name;
        }

        private DateTime GerRandomDate()
        {
            var today = DateTime.Now;

            var daysUntilDeadLine = this.randomGenerator.Next(1, 10);

            return new DateTime(today.Year, today.Month, today.Day + daysUntilDeadLine);
        }


    }
}
