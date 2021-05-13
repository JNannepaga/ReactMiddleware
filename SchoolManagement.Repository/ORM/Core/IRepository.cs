using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace SchoolManagement.Repository.ORM
{
    public interface IRepository<TEntity>
         where TEntity : class
    {
        TEntity NewEntity { get; }
        void Add(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);
        TEntity Get(int Id);
        TEntity Get(string name);
        IEnumerable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
    }
}
