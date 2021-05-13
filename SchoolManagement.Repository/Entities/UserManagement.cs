using System;

namespace SchoolManagement.Repository.Entities
{
    public class UserManagement
    {
        public int RegNum { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }
    }
}
