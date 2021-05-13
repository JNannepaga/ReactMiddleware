using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolManagement.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AppJwtAuth]
    public class TeacherController : ApiController
    {
           
    }
}