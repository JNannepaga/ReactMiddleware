using SchoolManagement.Repository.Entities;
using System.Linq;

namespace SchoolManagement.Repository.ORM.SQLProviderEF
{
    public class UserManagementRepository : Repository<UserManagement>, IUserManagementRepository
    {
        private readonly IDbAdapter _dbAdapter;
        public UserManagementRepository(IDbAdapter dbAdapter)
            : base(dbAdapter)
        {
            _dbAdapter = dbAdapter;
        }

        public UserManagement ValidateUser(string userName, string password)
        {
            return (_dbAdapter as EFAdapter).Set<UserManagement>().FirstOrDefault(cred => cred.UserName == userName && cred.Password == password);
        }
    }
}
