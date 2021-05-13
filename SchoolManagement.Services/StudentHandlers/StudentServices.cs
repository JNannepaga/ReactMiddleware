using SchoolManagement.Data.Models;
using SchoolManagement.Repository.ORM;
using SchoolManagement.Repository.ORM.SQLProviderEF;
using System;
using System.Collections.Generic;

namespace SchoolManagement.Services
{
    public class StudentServices : IStudentServices
    {
        public List<Student> GetAllStudents()
        {
            return new GetAllStudentsHandler().Invoke();
        }

        public Student GetMyDetails(int rollNum)
        {
            return new GetMyDetailsServiceHandler().Invoke(rollNum);
        }
    }
}
