namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students;

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<string>();
        }

        public Course(string courseName, string teacherName):this(courseName)
        {
            this.Name = courseName;
        }

        public Course(string courseName, string teacherName, IList<string> students):this(courseName,teacherName)
        {
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.ValidateNullOrEmpty(value, "name");

                this.name = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                Validator.ValidateNullOrEmpty(value, "teacherName");

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                Validator.ValidateNull(value, "students");

                this.students = value;
            }
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            var courseName = this.GetType().Name    ;

            StringBuilder result = new StringBuilder();

            result.Append(String.Format("{0} {{ Name = ",courseName));
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
