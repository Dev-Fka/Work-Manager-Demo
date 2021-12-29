using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManager.Entity;

namespace WorkManager.Database.Abstract
{
    public interface IWorkRepo : IRepo<Work>
    {
        Task<List<Work>> getBySucceeded();
        Task<List<Work>> getByMonthly();
        Task<List<Work>> getByWeekly();
        Task<List<Work>> getByDaily();


    }
}