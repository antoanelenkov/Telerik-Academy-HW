using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal,ISound
    {
        public Cat(int age, string name, bool isMale) : base(age, name, isMale) { }

        public override string MakeSound()
        {
            return "I am random cat: miau";
        }
    }
}
