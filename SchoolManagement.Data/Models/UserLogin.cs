using System;

namespace SchoolManagement.Data.Models
{
    public class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserLogin() { }
        public UserLogin(string userName, string password) 
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
