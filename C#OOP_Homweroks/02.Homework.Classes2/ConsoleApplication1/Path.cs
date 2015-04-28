
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    class Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.Sequence = new List<Point3D>();
        }

        public List<Point3D> Sequence { 
            get
            {
                return this.sequence;
            }
            set
            {
                this.sequence = value;
            }
        }

        public override string ToString()
        {
            return String.Join("\n",this.Sequence);
        }
    }
}
