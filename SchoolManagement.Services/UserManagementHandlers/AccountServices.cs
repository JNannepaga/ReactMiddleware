using SchoolManagement.Data.Models;
using System;

namespace SchoolManagement.Services
{
    public class AccountServices : IAccountServices
    {
        public bool ValidateUser(UserLogin userLogin, out string role)
        {
            return new ValidateUserHandler().Invoke(userLogin, out role);
        }

    }
}
