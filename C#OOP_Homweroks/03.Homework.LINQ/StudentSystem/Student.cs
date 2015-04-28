using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string phone;
        private string email;
        private List<byte> marks;
        private int groupNumber;

        public Student(string first, string last, int fn, string phone, string email, List<byte> marks, int groupNumber)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Fn = fn;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        public int GroupNumber
        {
            get { return groupNumber; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of the group must not be less than 1!");
                }
                else
                {
                groupNumber = value; 
                }

            }
        }
        

        public List<byte> Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        

        public int Fn
        {
            get { return fn; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The F.N. must not be less than 1!");
                }
                else
                {
                    fn = value;
                }

            }
        }
        

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override string ToString()
        {
            return String.Format("First name: {0} \nLast name: {1} \nFac. Number name: {2} \nPhone number name: {3} \nemail name: {4} \nMarks name: {5} \nGroup number name: {6}\n",
               this.FirstName, this.LastName, this.Fn,this.Phone, this.Email, String.Join(", ", this.Marks), this.GroupNumber);
        }
        
    }
}
