using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten:Cat,ISound
    {
        public Kitten(int age, string name) : base(age, name, false) { }

        public override string MakeSound()
        {
            return "I am Kitten: Miaaawww";
        }
    }
}
