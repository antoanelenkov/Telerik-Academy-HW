using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolSystem
{
    public class Comment
    {
        private static int IDsetter=1;

        private string commentText;
        private int commentID;

        public Comment(string text)
        {
            this.CommentText = text;
            this.commentID = IDsetter;
            IDsetter++;
        }
    
        public int CommentID
        {
            get
            {
                return this.commentID;
            }
        }

        public string CommentText
        {
            get
            {
                return this.commentText;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new IndexOutOfRangeException("The length of the comment must be at least one symbol.");
                }
                else
                {
                    this.commentText=value;
                }
            }
        }
    }
}
