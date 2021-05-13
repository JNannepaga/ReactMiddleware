using Mapster;
using Models = SchoolManagement.Data.Models;
using Entity = SchoolManagement.Repository.Entities;
using SchoolManagement.Repository.ORM;
using SchoolManagement.Repository.ORM.SQLProviderEF;

namespace SchoolManagement.Services
{
    internal class GetMyDetailsServiceHandler
    {
        private readonly IStudentRepository _studentRepository;

        public GetMyDetailsServiceHandler()
        {
            _studentRepository = new ApplicationDbContext().StudentRepository;
        }

        public Models.Student Invoke(int rollNum)
        {
            return _studentRepository.Get(rollNum).Adapt<Models.Student>();
        }
    }
}
