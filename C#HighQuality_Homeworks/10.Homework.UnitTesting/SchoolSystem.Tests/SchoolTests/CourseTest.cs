using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystem.Tests.SchoolTests
{
    [TestClass]
    public class CourseTest
    {
        private Course course1;
        private Student[] collectionWithStudents;

        [TestInitialize]
        public void GenerateComponents()
        {
            this.collectionWithStudents=this.StudentsGenerator();
            this.course1 = new Course();
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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ShouldNotAddMoreThan30Students()
        {
            foreach (var student in this.collectionWithStudents)
            {
                this.course1.AddStudent(student);
            }          
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotRemoveStudentIfNotInThisCourse()
        {
            course1.RemoveStudent(new Student("Random"));
        }
    }
}
