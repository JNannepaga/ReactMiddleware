using SchoolManagement.Repository.ORM;
using SchoolManagement.Repository.ORM.SQLProviderEF;
using Mapster;
using Models = SchoolManagement.Data.Models;
using Entity = SchoolManagement.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement.Services
{
    internal class GetAllStudentsHandler
    {
        private readonly IStudentRepository _studentRepository;

        public GetAllStudentsHandler()
        {
            _studentRepository = new ApplicationDbContext().StudentRepository;
        }

        public List<Models.Student> Invoke()
        {
            return _studentRepository.GetAll().Adapt<List<Models.Student>>();
        }
    }
}
