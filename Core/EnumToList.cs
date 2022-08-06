using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class EnumToList
    {
        #region metodo para criar uma lista aprtir de enum
        public static IList<T> getListEnum<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T não é um Enum");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
        #endregion
    }
}
