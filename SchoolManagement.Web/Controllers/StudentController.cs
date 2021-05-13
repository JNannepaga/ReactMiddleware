using SchoolManagement.Data.Models;
using SchoolManagement.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolManagement.Web.Controllers
{

    [EnableCors(origins: "*", headers:"*", methods:"*")]
    public class StudentController : ApiController
    {
        private readonly IStudentServices _studentServices;
        public StudentController()
        {
            _studentServices = new StudentServices();
        }

        [HttpGet]
        public HttpResponseMessage GetStudentByRollNumber([FromUri]int rollNumber)
        {
            Student result = _studentServices.GetMyDetails(rollNumber);
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [AppJwtAuth]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public HttpResponseMessage GetAllStudents()
        {
            List<Student> students = _studentServices.GetAllStudents();
            return this.Request.CreateResponse(HttpStatusCode.OK, students);
        }
    }
}
