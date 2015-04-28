using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    class Group
    {
        private int groupNumber;

        public int GroupNumber
        {
            get { return groupNumber; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of the group must not be less than 1!");
                }
                else
                {
                groupNumber = value; 
                }

            }
        }
        
        public string DepartmentName { get; set; }

        public Group(int groupNumber)
        {
            this.GroupNumber = groupNumber;
        }

        public Group(int groupNumber, string depratmentName)
            : this(groupNumber)
        {
            this.DepartmentName = depratmentName;
        }
    }
}
