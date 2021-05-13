using SchoolManagement.Services;
using SchoolManagement.Repository.Models;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace SchoolManagement.Web.Controllers

{
    public class StudentController : BaseController
    {
        private readonly IStudentServices _studentServices;

        public StudentController()
        {
            _studentServices = new StudentServices();
        }

        [HttpGet]
        public HttpResponseMessage GetStudentDetailsById(int studentId)
        {
            var result = _studentServices.GetMyDetails(studentId);
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}