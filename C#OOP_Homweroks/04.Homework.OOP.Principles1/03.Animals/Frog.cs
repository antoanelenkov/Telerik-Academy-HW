using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog : Animal,ISound
    {
        public Frog(int age, string name, bool isMale) : base(age, name, isMale) { }

        public override string MakeSound()
        {
            return "I am frog: Kwa Kwa";
        }
    }
}
