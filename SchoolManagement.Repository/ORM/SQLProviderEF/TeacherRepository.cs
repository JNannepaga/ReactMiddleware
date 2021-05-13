using SchoolManagement.Repository.Entities;
using System;
using System.Collections.Generic;

namespace SchoolManagement.Repository.ORM.SQLProviderEF
{
    public class TeacherRepository : Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(IDbAdapter dbAdapter)
            : base(dbAdapter)
        {

        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public ICollection<Teacher> GetColleguesByTeacherId(int teacherId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Student> GetStudentsByTeacherId(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
