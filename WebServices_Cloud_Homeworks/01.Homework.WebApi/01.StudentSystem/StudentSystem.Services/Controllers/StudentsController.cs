namespace StudentSystem.Services.Controllers
{
    using Data;
    using Models;
    using StudentSystem.Models;
    using System.Web.Http;
    using System.Linq;
    using System;

    public class StudentsController : ApiController
    {
        private IStudentSystemData db;

        public StudentsController() : this(new StudentsSystemData())
        {
        }

        public StudentsController(IStudentSystemData db)
        {
            this.db = db;
        }

        [HttpGet]
        public IHttpActionResult GetById(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid type of parameter for id");
            }

            var student = this.db.Students.SearchFor(x => x.StudentIdentification == id).FirstOrDefault();

            if (student == null)
            {
                return BadRequest("There is no user with such id");
            }
            else
            {
                return Ok(student);
            }
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var students = this.db.Students.All();

            return Ok(students);
        }

        [HttpPost]
        public IHttpActionResult Create([FromUri]StudentModel student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentToAdd = new Student { FirstName = student.FirstName, LastName = student.LastName, Level = student.Level };

            this.db.Students.Add(studentToAdd);
            this.db.SaveChanges();

            student.Id = studentToAdd.StudentIdentification;

            return Ok(student);
        }


        [HttpPost]
        public IHttpActionResult Update(int? id,StudentModel student)
        {
            if (id == null)
            {
                return BadRequest("Invalid type of parameter for id");
            }

            var studentToUpdate = this.db.Students.SearchFor(x => x.StudentIdentification == id).FirstOrDefault();

            if (studentToUpdate == null)
            {
                return BadRequest("There is no user with such id");
            }
            else if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.LastName = student.LastName;
                studentToUpdate.Level = student.Level;               

                this.db.SaveChanges();

                student.Id = studentToUpdate.StudentIdentification;

                return Ok(student);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest("Invalid type of parameter for id");
            }

            var studentToDelete = this.db.Students.SearchFor(x => x.StudentIdentification == id).FirstOrDefault();

            if (studentToDelete == null)
            {
                return BadRequest("There is no user with such id");
            }
            else
            {
                this.db.Students.Delete(studentToDelete);
                this.db.SaveChanges();

                return Ok(studentToDelete);
            }
        }

        [HttpPost]
        public IHttpActionResult AddCourse(string coucrseId, int studentId)
        {
            var courseIdAsGuid = new Guid(coucrseId);
            var course = this.db.Courses.All().FirstOrDefault(c => c.Id == courseIdAsGuid);
            if (course == null)
            {
                return BadRequest("Course  not found - probably invalid course ID");
            }

            var student = this.db.Students.All().FirstOrDefault(s => s.StudentIdentification == studentId);
            if (student == null)
            {
                return BadRequest("Student not found - probably invalid id.");
            }

            student.Courses.Add(course);
            this.db.SaveChanges();

            return Ok();
        }

    }
}