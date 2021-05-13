using System;
using System.Collections.Generic;

namespace SchoolManagement.Repository.ORM
{
    public interface IDbAdapter : IDisposable
    {
        IEnumerable<TResult> Select<TResult>(string query, params object[] sqlParams);

        TResult SelectSingle<TResult>(string query, params object[] sqlParams);

        IEnumerable<TResult> Execute<TResult>(string spName, params object[] sqlParams);
    }
}
