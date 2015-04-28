using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SchoolSystem
{
    public class Teacher : Person
    {
        private HashSet<Disciplines> disciplines=new HashSet<Disciplines>();

        public Teacher(string name, params Disciplines[] disciplines)
            : base(name)
        {
            foreach (var discipline in disciplines)
            {
                this.disciplines.Add(discipline);
            }
        }

        public Teacher(string name, Comment textComment, params Disciplines[] disciplines)
            : base(name, textComment)
        {
            foreach (var discipline in disciplines)
            {
                this.disciplines.Add(discipline);
            }
        }

        public HashSet<Disciplines> Disciplines
        {
            get
            {
                return this.Disciplines;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new IndexOutOfRangeException("The number of disciplines must be at least one .");
                }
                else
                {
                    this.Disciplines = value;
                }
            }
        }

        public void AddDiscipline(Disciplines discipline)
        {
            this.Disciplines.Add(discipline);
        }
    }
}
