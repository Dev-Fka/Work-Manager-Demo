using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManager.Database.Abstract;
using WorkManager.Entity;
using WorkManager.Service.Abstract;

namespace WorkManager.Service.Concrete
{
    public class MyWorkManager : IService
    {
        private IWorkRepo workRepo;
        public MyWorkManager(IWorkRepo _workRepo)
        {
            this.workRepo = _workRepo;
        }

        public async Task create(Work entity)
        {
            await workRepo.create(entity);
        }

        public async Task delete(Work entity)
        {
            await workRepo.delete(entity);
        }

        public async Task<List<Work>> getAll()
        {
            return await workRepo.getAll();
        }

        public async Task<Work> getById(int id)
        {
            return await workRepo.getById(id);
        }

        public async Task update(Work entity)
        {
            await workRepo.update(entity);
        }

        public async Task<List<Work>> getBySucceeded()
        {
            return await workRepo.getBySucceeded();
        }

        public async Task<List<Work>> getByMonthly()
        {
            return await workRepo.getByMonthly();
        }

        public async Task<List<Work>> getByWeekly()
        {
            return await workRepo.getByWeekly();
        }

        public async Task<List<Work>> getByDaily()
        {
            return await workRepo.getByDaily();
        }


    }
}