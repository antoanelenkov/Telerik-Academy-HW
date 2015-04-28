using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            if (age == null)
            {
                return string.Format("name: {0}{1}age is not specified", name,Environment.NewLine);
            }
            return string.Format("name: {0}, age: {1}", name, age);
        }

    }
}