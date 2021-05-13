using SchoolManagement.Repository.Entities;

namespace SchoolManagement.Repository.ORM
{
    public interface IUserManagementRepository : IRepository<UserManagement>
    {
        UserManagement ValidateUser(string userName, string password);
    }
}
