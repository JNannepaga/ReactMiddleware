using SchoolManagement.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace SchoolManagement.Repository.ORM.SQLProviderEF
{
    class EFAdapter : DbContext, IDbAdapter
    {
        public EFAdapter()
            :this("SchoolManagementDbcs")
        {

        }

        public EFAdapter(string connectionString)
            : base($"name={connectionString}")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentEntityMapping());
            modelBuilder.Configurations.Add(new TeacherEntityMapping());
            modelBuilder.Configurations.Add(new UserManagementEntityMapping());
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public IEnumerable<TResult> Execute<TResult>(string spName, params object[] sqlParams)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> Select<TResult>(string query, params object[] sqlParams)
        {
            throw new NotImplementedException();
        }

        public TResult SelectSingle<TResult>(string query, params object[] sqlParams)
        {
            throw new NotImplementedException();
        }
    }
}
