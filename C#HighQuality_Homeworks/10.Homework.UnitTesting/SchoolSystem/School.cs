using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School
    {
        private const int MinimumId = 10000;
        private const int MaximumId = 99999;

        private int uniqueNumber = MinimumId;
        private IDictionary<Student, int> studentsCollection;
        //list with free uqnique numbers.The list is filled with the numbers from deleted students
        private IList<int> freeUniqueNumbers;

        public School()
        {
            this.studentsCollection = new Dictionary<Student, int>();
            this.freeUniqueNumbers = new List<int>();
        }

        public IDictionary<Student, int> StudentsCollection
        {
            get
            {
                return this.studentsCollection;
            }
        }

        public int UniqueNumber
        {
            private set
            {
                if (value < MinimumId || value > MaximumId)
                {
                    throw new IndexOutOfRangeException("the unique number is out of range");
                }
                this.uniqueNumber = value;
            }
            get
            {
                return this.uniqueNumber;
            }
        }

        public void AddStudent(Student currentStudent)
        {
            if (uniqueNumber == MaximumId)
            {
                throw new ArgumentOutOfRangeException("This school is already full.");
            }
            int currentUniqueNumber = -1;
            if (freeUniqueNumbers.Count > 0)
            {
                currentUniqueNumber = freeUniqueNumbers[freeUniqueNumbers.Count - 1];
                freeUniqueNumbers.Remove(freeUniqueNumbers[freeUniqueNumbers.Count - 1]);
                this.studentsCollection.Add(currentStudent, currentUniqueNumber);
            }
            else
            {
                currentUniqueNumber = uniqueNumber;
                this.studentsCollection.Add(currentStudent, currentUniqueNumber);
                uniqueNumber++;
            }
        }

        public void RemoveStudent(Student currentStudent)
        {
            if (!this.studentsCollection.ContainsKey(currentStudent))
            {
                throw new ArgumentException("This student is not presented in the this school");
            }
            this.freeUniqueNumbers.Add(studentsCollection[currentStudent]);
            this.studentsCollection.Remove(currentStudent);
        }
    }
}
