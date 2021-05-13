using SchoolManagement.Data.Models;

namespace SchoolManagement.Services
{
    public interface IAccountServices
    {
        bool ValidateUser(UserLogin userLogin, out string role);
    }
}
