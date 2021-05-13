using Mapster;
using Model = SchoolManagement.Data.Models;
using Entity = SchoolManagement.Repository.Entities;
using SchoolManagement.Repository.ORM;
using SchoolManagement.Repository.ORM.SQLProviderEF;

namespace SchoolManagement.Services
{
    internal class ValidateUserHandler
    {
        private readonly IUserManagementRepository _userManagementRepository;
        public ValidateUserHandler()
        {
            _userManagementRepository = new ApplicationDbContext().UserManagementRepository;
        }

        public bool Invoke(Model.UserLogin userLogin, out string role)
        {
            Model.CurrentUser currentUser = _userManagementRepository.ValidateUser(userLogin.UserName, userLogin.Password).Adapt<Model.CurrentUser>();

            if (currentUser != null)
            {
                role = this.getRoleById(currentUser.Role);
                return true;
            }
            else
            {
                role = "NONE";
                return false;
            }
            
        }

        public string getRoleById(int roleId)
        {
        
            string roleName = string.Empty;
            switch (roleId)
            {
                case 1:
                    roleName = "SuperAdmin";
                    break;

                case 2:
                    roleName = "Admin";
                    break;

                case 3:
                    roleName = "SuperUser";
                    break;

                case 4:
                    roleName = "User";
                    break;

                default:
                    break;
            }
            return roleName;
        }
    }
}
