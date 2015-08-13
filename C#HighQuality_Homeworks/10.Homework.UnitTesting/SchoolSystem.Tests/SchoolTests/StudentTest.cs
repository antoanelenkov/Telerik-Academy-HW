namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_WithEmptyValue_ShouldThrow()
        {
            Student Antoan = new Student("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Student_WithNullValue_ShouldThrow()
        {
            Student Antoan = new Student(null);
        }

        [TestMethod]
        public void StudentName_GetterAndSetter()
        {
            string name = "Antoan2";
            Student testStudent = new Student(name);

            Assert.AreEqual(name, testStudent.Name);
        }
    }
}
