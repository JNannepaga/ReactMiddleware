using SchoolManagement.Data.Models;
using SchoolManagement.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolManagement.Web.CookieAuth.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IAccountServices _accountServices;
        
        public AccountController()
        {
            _accountServices = new AccountServices();
        }
    }
}
