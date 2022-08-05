using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public interface ICrudRepository<T, K> where T : class
    {
        List<T> GetAll();

        T FindByCodigo( K codigo );

        void SaveAll(List<T> entities);

        int RemoveAll( Predicate<T> match );
    }
}
