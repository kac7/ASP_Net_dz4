using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_MVC_dz4.Models
{
    interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        bool Delete(int id);
    }
}
