using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public class StudentsClass
    {
        private static int iDsetter;

        private int classID;
        private Comment classComment;
        private HashSet<Teacher> classTeachers=new HashSet<Teacher>();

        public StudentsClass(params Teacher[] teachers)
        {
            foreach (var teacher in teachers)
            {
                this.classTeachers.Add(teacher);
            }
            this.classID = StudentsClass.iDsetter;
            iDsetter++;
        }

        static public int IDsetter
        {
            get
            {
                return iDsetter;
            }

        }

        public int ClassID
        {
            get
            {
                return this.classID;
            }
        }



        public HashSet<Teacher> ClassTeachers
        {
            get
            {
                return this.classTeachers;
            }
            set
            {
                if (value.Count <= 0)
                {
                    throw new ArgumentException("The number of teachers must be at least one.");
                }
                else
                {
                    this.classTeachers = value;
                }
            }
        }

        public Comment ClassComment
        {
            get
            {
                return this.classComment;
            }
            set
            {
                this.classComment = value;
            }
        }
    }
}
