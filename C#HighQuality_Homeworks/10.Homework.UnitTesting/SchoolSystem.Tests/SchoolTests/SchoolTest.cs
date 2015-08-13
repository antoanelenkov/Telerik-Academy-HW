namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Diagnostics;

    [TestClass]
    public class SchoolTest
    {
        private Student student1;
        private School MathGymn;

        [TestInitialize]
        public void InitializeComponents()
        {
            student1 = new Student("Antoan");
            MathGymn = new School();
        }

        [TestMethod]
        public void StudentsCollection_ShouldHaveCount1()
        {
            MathGymn.AddStudent(student1);
            Assert.AreEqual(1, MathGymn.StudentsCollection.Count);       
        }

        [TestMethod]
        public void StudentsCollection_ShouldHaveCount0()
        {
            MathGymn.AddStudent(student1);
            MathGymn.RemoveStudent(student1);
            Assert.AreEqual(0, MathGymn.StudentsCollection.Count);
        }

        [TestMethod]
        public void School_ShouldHasStartingID10000()
        {
            Assert.AreEqual(10000, MathGymn.UniqueNumber);
        }

        [TestMethod]
        public void AddStudent_ShouldHasID10000()
        {
            MathGymn.AddStudent(student1);
            Assert.AreEqual(10000, MathGymn.StudentsCollection[student1]);
        }


        [TestMethod]
        public void AddStudent_WithUsedButAlreadyFreeUniqueNumber_ShouldBeAdded()
        {
            MathGymn.AddStudent(student1);
            MathGymn.RemoveStudent(student1);
            var student2 = new Student("Georgi");
            MathGymn.AddStudent(student2);
            Assert.AreEqual(10000,MathGymn.StudentsCollection[student2], "The ID is not the proper one");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudent_WhenSchoolIsFull_ShouldThrow()
        {
            for (int i = 0; i < 100000; i++)
            {
                this.MathGymn.AddStudent(new Student("Student " + i));

                //testing the trace logger
                Trace.WriteLine("Student " + i);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudent_IfNotInThisCourse_ShouldThrow()
        {
            MathGymn.RemoveStudent(new Student("Random"));
        }
    }
}
