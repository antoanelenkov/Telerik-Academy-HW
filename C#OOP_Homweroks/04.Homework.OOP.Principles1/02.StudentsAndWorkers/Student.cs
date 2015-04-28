using System;
using System.Collections.Generic;

namespace StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade): base(firstName, lastName)
        {
            Grade = grade;
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 7 || value > 12)
                {
                    throw new IndexOutOfRangeException("The grade must be between 7 and 12");
                }
                else{grade = value;}                  
            }
        }

    }
}
