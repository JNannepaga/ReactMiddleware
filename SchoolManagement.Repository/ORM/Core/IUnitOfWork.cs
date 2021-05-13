using System;

namespace SchoolManagement.Repository.ORM
{
    public interface IUnitOfWork : IDisposable

    {
        //List of Repositories

        IStudentRepository StudentRepository { get; }

        ITeacherRepository TeacherRepository { get; }

        IUserManagementRepository UserManagementRepository { get; }
         void SaveChanges();
         void Update<TEntity>(TEntity entity)
           where TEntity : class;
    }
}
