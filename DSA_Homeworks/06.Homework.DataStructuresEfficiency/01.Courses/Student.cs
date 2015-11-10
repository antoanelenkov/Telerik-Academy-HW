namespace _01.Courses
{
    using System;

    class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompareTo(Student other)
        {
            var firstCriteria = this.LastName.CompareTo(other.LastName);

            if (firstCriteria == 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else
            {
                return firstCriteria;
            }          
        }
    }
}
