using SchoolManagement.Repository.Entities;
using System;

namespace SchoolManagement.Repository.ORM.SQLProviderEF
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(IDbAdapter dbAdapter)
            : base(dbAdapter)
        {

        }

        public Student GetAllStudentsOfStandardByStudentRollId(int studentRollId)
        {
            throw new NotImplementedException();
        }
    }
}
