using SchoolManagement.Data.Models;
using SchoolManagement.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolManagement.Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountController : ApiController
    {
        private readonly IAccountServices _accountServices;
        
        public AccountController()
        {
            _accountServices = new AccountServices();
        }

        [HttpPost]
        [AllowAnonymous]
        public HttpResponseMessage Token(UserLogin credentials)
        {
            string role = string.Empty;
            if (_accountServices.ValidateUser(credentials, out role))
            {
                return Request.CreateResponse(HttpStatusCode.OK, TokenManager.GenerateToken(credentials.UserName, role));
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadGateway, "Invalid Credentials");
            }
        }

    }
}
