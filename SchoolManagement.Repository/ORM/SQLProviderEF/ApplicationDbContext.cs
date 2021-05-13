using System.Data.Entity;

namespace SchoolManagement.Repository.ORM.SQLProviderEF
{
    public class ApplicationDbContext : IUnitOfWork
    {
        protected readonly IDbAdapter _dbAdapter;

        public ApplicationDbContext()
        {
            _dbAdapter = new EFAdapter();
            StudentRepository = new StudentRepository(_dbAdapter);
            TeacherRepository = new TeacherRepository(_dbAdapter);
            UserManagementRepository = new UserManagementRepository(_dbAdapter);
        }

        public IStudentRepository StudentRepository { get ; private set ; }
        public ITeacherRepository TeacherRepository { get ; private set; }
        public IUserManagementRepository UserManagementRepository { get; private set; }
        public void Dispose()
        {
            _dbAdapter.Dispose();
        }

        public void SaveChanges()
        {
            (_dbAdapter as EFAdapter).SaveChanges();
        }

        public void Update<TEntity>(TEntity entity)
            where TEntity : class
        {
            (_dbAdapter as EFAdapter).Entry<TEntity>(entity).State = EntityState.Modified;
        }
    }
}
