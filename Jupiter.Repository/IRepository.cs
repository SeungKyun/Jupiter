using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jupiter.Repository
{
    public interface IRepository<T> : IDisposable
    {
        void Insert(T model);
        void Insert(List<T> models);
        T GetById(Object id);
        List<T> GetById(List<Object> ids);
        PagedList<T> GetAll(int? page, int? pageSize);
        void Delete(T model);
        void Delete(List<T> models);
        int SaveChanges();
    }
}
