using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class TomCat : Cat, ISound
    {
        public TomCat(int age, string name) : base(age, name, true) { }

        public override string MakeSound()
        {
            return "I am TomCat: Miaaawww";
        }
    }
}
