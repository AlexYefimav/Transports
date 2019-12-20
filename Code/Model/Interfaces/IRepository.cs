using System.Collections.Generic;

namespace Transports.Code.Model
{
    interface IRepository<T>
    {
        void Add(T obj);
        void Update(int id, T obj);
        void Remove(int id);
        T Find(int id);
        IList<T> FindAll();
    }
}
