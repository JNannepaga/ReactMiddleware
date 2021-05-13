using SchoolManagement.Repository.Entities;
using System;
using System.Collections.Generic;


namespace SchoolManagement.Repository.ORM
{
    public interface ITeacherRepository
    {
        void AddStudent(Student student);
        ICollection<Student> GetStudentsByTeacherId(int teacherId);
        ICollection<Teacher> GetColleguesByTeacherId(int teacherId);
    }
}
