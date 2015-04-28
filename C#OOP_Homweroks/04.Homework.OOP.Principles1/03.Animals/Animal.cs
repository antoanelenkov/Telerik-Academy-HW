using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface ISound
    {
        string MakeSound();
    }

    abstract class Animal:ISound
    {


        private int age;
        private string name;
        private bool isMale;

        protected Animal(int age, string name, bool isMale)
        {
            this.Age = age;
            this.Name = name;
            this.IsMale = isMale;
        }

        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
        
        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("The age must be more than 0.");
                }
                else
                {
                    this.age = value;
                }
                }               
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new IndexOutOfRangeException("The name must be at least one symbol.");
                }
                else { this.name = value; }
            }
        }

        public virtual string MakeSound()
        {
            return "I am random animal!?!? What do u expect me to say???";
        }
    }
}
