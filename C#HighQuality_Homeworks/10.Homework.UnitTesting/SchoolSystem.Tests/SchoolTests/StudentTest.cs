namespace SchoolSystem.Tests.SchoolTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldNotAddEmpyValue()
        {
            Student Antoan = new Student("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ShouldNotAddNullValue()
        {
            Student Antoan = new Student(null);
        }
    }
}
