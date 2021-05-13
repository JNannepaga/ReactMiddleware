using SchoolManagement.Repository.Entities;
using System;

namespace SchoolManagement.Repository.ORM
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetAllStudentsOfStandardByStudentRollId(int studentRollId);
    }
}
