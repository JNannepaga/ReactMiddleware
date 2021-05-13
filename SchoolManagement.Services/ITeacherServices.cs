using SchoolManagement.Data.Models;
using System.Collections.Generic;

namespace SchoolManagement.Services
{
    public interface ITeacherServices
    {
        void AddStudent(Student student);

        ICollection<Teacher> GetMyCollegues(int TeacherId);
    }
}
