using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManager.Entity;

namespace WorkManager.Service.Abstract
{
    public interface IService
    {
        Task<List<Work>> getAll();
        Task<Work> getById(int id);
        Task<List<Work>> getBySucceeded();
        Task<List<Work>> getByMonthly();
        Task<List<Work>> getByWeekly();
        Task<List<Work>> getByDaily();
        Task create(Work entity);
        Task update(Work entity);
        Task delete(Work entity);
    }
}