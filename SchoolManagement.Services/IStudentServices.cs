using SchoolManagement.Data.Models;
using System.Collections.Generic;

namespace SchoolManagement.Services
{
    public interface IStudentServices
    {
        Student GetMyDetails(int rollNum);

        List<Student> GetAllStudents();
    }
}
