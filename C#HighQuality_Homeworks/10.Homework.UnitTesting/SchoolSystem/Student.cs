namespace SchoolSystem
{
    using System;

    public class Student
    {
        private string name;
  
        public Student(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Name can not be null or empty");
                }
                name = value;
            }
        }
    }
}
