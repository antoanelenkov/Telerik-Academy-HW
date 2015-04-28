using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public class Student : Person
    {
        private int classID;

        public Student(string name,int classID):base(name)       
        {
            this.ClassID = classID;
        }

        public Student(string name, int classID, Comment text):base(name,text)
        {
            this.ClassID = classID;
        }

    
        public int ClassID
        {
            get
            {
                return this.classID;
            }
            set
            {
                if (value > StudentsClass.IDsetter)
                {
                    throw new IndexOutOfRangeException("there is no such ID of the class");
                }
                else
                {
                    this.classID=value;
                }
            }
        }


    }
}
