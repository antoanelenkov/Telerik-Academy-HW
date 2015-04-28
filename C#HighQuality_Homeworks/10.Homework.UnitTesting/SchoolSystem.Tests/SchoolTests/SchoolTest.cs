using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolSystem.Tests.SchoolTests
{
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
        public void CollectionShouldHaveCount1()
        {
            MathGymn.AddStudent(student1);
            Assert.AreEqual(1, MathGymn.StudentsCollection.Count);       
        }

        [TestMethod]
        public void CollectionShouldHaveCount0()
        {
            MathGymn.AddStudent(student1);
            MathGymn.RemoveStudent(student1);
            Assert.AreEqual(0, MathGymn.StudentsCollection.Count);
        }

        [TestMethod]
        public void StudentShouldHasID10000()
        {
            Assert.AreEqual(10000, MathGymn.UniqueNumber);
        }

        [TestMethod]
        public void StudentInCollectionShouldHasID10000()
        {
            MathGymn.AddStudent(student1);
            Assert.AreEqual(10000, MathGymn.StudentsCollection[student1]);
        }


        [TestMethod]
        public void ShouldAddStudentWithUsedUniqueNumber()
        {
            MathGymn.AddStudent(student1);
            MathGymn.RemoveStudent(student1);
            var student2 = new Student("Georgi");
            MathGymn.AddStudent(student2);
            Assert.AreEqual(10000,MathGymn.StudentsCollection[student2], "The ID is not the proper one");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldNotRemoveStudentIfNotInThisCourse()
        {
            MathGymn.RemoveStudent(new Student("Random"));
        }
    }
}
