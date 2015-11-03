namespace StudentSystem.Web.Controllers
{
    using Models;
    using Data;
    using System.Linq;
    using System.Web.Http;
    using System.Net.Http;
    using System.Net;

    public class StudentsController : ApiController
    {
        private IStudentSystemData db;

        public StudentsController()
        {
            this.db = new StudentsSystemData();
        }

        [HttpGet]
        public HttpResponseMessage All()
        {
            var students = this.db.Students;

            if (students != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, students);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No students found");
            }
        }
    }
}