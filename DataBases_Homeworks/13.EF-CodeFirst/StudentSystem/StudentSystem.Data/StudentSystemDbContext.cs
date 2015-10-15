namespace StudentSystem.Data
{
    using Models;
    using Migrations;
    using System.Data.Entity;

    public class StudentSystemDbContext:DbContext
    {
        public StudentSystemDbContext() 
            :base("StudentsSystemCS")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());     
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }
    }
}
