using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SchoolSystem.Tests.SchoolTests
{
    [TestClass]
    public class CourseTest
    {
        private Course course1;
        private Student testStudent;
        private Student[] collectionWithStudents;

        [TestInitialize]
        public void GenerateComponents()
        {
            this.collectionWithStudents=this.StudentsGenerator();
            this.course1 = new Course();
            this.testStudent = new Student("as");
        }


        private Student[] StudentsGenerator()
        {
            Student[] arrWithStudents = new Student[31];
            for (int i = 0; i < 31; i++)
            {
                arrWithStudents[i] = new Student(String.Format("Student{0}", i));
            }
            return arrWithStudents;
        }

        [TestMethod]
        public void CreateCourse()
        {
            var testCourse = new Course(new HashSet<Student>());

            Assert.IsInstanceOfType(testCourse,typeof(Course));
        }

        [TestMethod]
        public void AddStudent()
        {
            this.course1.AddStudent(this.testStudent);

            Assert.AreEqual(1, course1.SetOfStudents.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddStudent_ShouldNotAddMoreThan30Students()
        {
            foreach (var student in this.collectionWithStudents)
            {
                this.course1.AddStudent(student);
            }          
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudent_IfNotInThisCourse_ShouldThrow()
        {
            course1.RemoveStudent(new Student("Random"));
        }

        [TestMethod]
        public void RemoveStudent_IfInThisCourse()
        {
            course1.AddStudent(this.testStudent);
            course1.RemoveStudent(this.testStudent);

            Assert.AreEqual(0, course1.SetOfStudents.Count);
        }
    }
}
