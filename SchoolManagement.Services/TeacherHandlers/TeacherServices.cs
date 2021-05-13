using SchoolManagement.Data.Models;
using SchoolManagement.Repository.ORM;
using SchoolManagement.Repository.ORM.SQLProviderEF;
using System;
using System.Collections.Generic;

namespace SchoolManagement.Services
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherServices()
        {
            _teacherRepository = new ApplicationDbContext().TeacherRepository;
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public ICollection<Teacher> GetMyCollegues(int teacherId)
        {
            return null;
        }
    }
}
