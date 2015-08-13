using System;
using System.Collections.Generic;

namespace SchoolSystem
{
    public class Course
    {
        private const int MaxNumberOfStudents=30;

        private ISet<Student> setOfStudents;

        public ISet<Student> SetOfStudents
        {
            get
            {
                return this.setOfStudents;
            }
        }

        public Course(ISet<Student> set)
        {
            this.setOfStudents = set;
        }

        public Course()
        {
            this.setOfStudents = new HashSet<Student>();
        }

        public void AddStudent(Student current)
        {
            if(this.SetOfStudents.Count==MaxNumberOfStudents)
            {
                throw new IndexOutOfRangeException("The students can not be more than 30");
            }
                this.setOfStudents.Add(current);
        }

        public void RemoveStudent(Student current)
        {
            if (!this.setOfStudents.Contains(current))
            {
                throw new ArgumentException("This student is not presented in the this course");
            }
            this.setOfStudents.Remove(current);
        }
    }
}
