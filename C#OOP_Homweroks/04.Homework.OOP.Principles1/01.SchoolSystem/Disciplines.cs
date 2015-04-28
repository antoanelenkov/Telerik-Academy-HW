using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public class Disciplines
    {
        private string name;
        private int numberOfExercises;
        private int numberOfLectures;
        private Comment discComment;

        public Disciplines(string name, int numberOfExercises, int numberOfLecutres)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLectures = numberOfLecutres;
        }

        public Disciplines(string name, int numberOfExercises, int numberOfLecutres, Comment comment)
            : this(name, numberOfExercises, numberOfLecutres)
        {
            this.DiscComment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new IndexOutOfRangeException("The length of the text must be at least one symbol.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The number of lectures must be at least one .");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value == 0)
                {
                    throw new IndexOutOfRangeException("The number of exercises must be at least one .");
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
        }

        public Comment DiscComment
        {
            get
            {
                return this.discComment;
            }
            set
            {
                this.discComment = value;
            }
        }
    }
}
