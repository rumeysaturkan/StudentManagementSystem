using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Forms
{
    public interface IDal<T> : IEntity
    {
        List<T> GetAll();

        void Add(T entity);
        void Uptade(T entity);
        void Delete(T entity);
    }
}
