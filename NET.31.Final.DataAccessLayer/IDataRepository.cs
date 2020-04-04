using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NET._31.Final.DataAccessLayer
{
    public interface IDataRepository<T>
    {
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }
}
