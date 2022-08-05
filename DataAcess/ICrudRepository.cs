using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    class ICrudRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Find(Expression<Func<T, bool>> filter);

        void Insert(T entity);

        int RemoveAll( Predicate<T> match );

        IQueryable<T> Where(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderyBy = null);

        int Count(Expression<Func<T, bool>> filter = null);
    }
}
