using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public abstract class Person
    {
        private Comment comment;
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, Comment text)
        {
            this.Name = name;
            this.Comment = text;
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

        public Comment Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
