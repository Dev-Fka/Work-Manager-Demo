using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkManager.Database.Abstract
{
    public interface IRepo<T>
    {
        Task<List<T>> getAll();
        Task<T> getById(int id);
        Task create(T entity);
        Task update(T entity);
        Task delete(T entity);
    }
}