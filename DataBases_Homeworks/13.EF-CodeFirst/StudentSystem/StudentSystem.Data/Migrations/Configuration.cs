namespace StudentSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.DataSeeder = new DataSeeder();
        }

        public DataSeeder DataSeeder { get; set; }

        protected override void Seed(StudentSystemDbContext context)
        {
            var students = this.DataSeeder.Students;
            var courses = this.DataSeeder.Courses;
            var homeworks = this.DataSeeder.Homeworks;

            context.Students.AddOrUpdate(students.ToArray());
            context.Courses.AddOrUpdate(courses.ToArray());
            context.Homeworks.AddOrUpdate(homeworks.ToArray());

            context.SaveChanges();
        }
    }
}
