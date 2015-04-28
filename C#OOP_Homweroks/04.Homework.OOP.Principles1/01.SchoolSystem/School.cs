using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public class School
    {
        private static int IDsetter=1;

        private HashSet<StudentsClass> classes=new HashSet<StudentsClass>();
        private string name;
        private int schoolID;

        public School(string name, params StudentsClass[] classes)
        {
            this.Name = name;
            foreach (var classs in classes)
            {
                this.classes.Add(classs);
            }
            this.schoolID = IDsetter;
            IDsetter++;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new IndexOutOfRangeException("The length of the text must be at least one symbol.");
                }
                else
                {
                    this.name = value;
                }
            }

        }

        public int SchoolID
        {
            get
            {
                return this.schoolID;
            }
        }

        public HashSet<StudentsClass> Classes
        {
            get
            {
                return this.classes;
            }
            set
            {
                if (value.Count <5)
                {
                    throw new ArgumentException("The class must has at least 5 students.");
                }
                else
                {
                    this.classes = value;
                }
            }
        }
    }
}
