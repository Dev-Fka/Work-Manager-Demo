using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkManager.Database.Abstract;
using WorkManager.Entity;
using Microsoft.EntityFrameworkCore;
namespace WorkManager.Database.Concrete.EFCore
{
    public class EFCoreWorkRepo : EFCoreGenericRepo<Work>, IWorkRepo
    {

        public EFCoreWorkRepo(WorkContext context) : base(context)
        {

        }
        private WorkContext context
        {
            get { return context as WorkContext; }
        }

        public async Task<List<Work>> getByDaily()
        {

            return await context.Works
                            .Where(i => i.isDaily == true)
                            .ToListAsync();


        }

        public async Task<List<Work>> getByMonthly()
        {

            return await context.Works
                            .Where(i => i.isMonthly == true)
                            .ToListAsync();


        }
        public async Task<List<Work>> getBySucceeded()
        {

            return await context.Works
                            .Where(i => i.isSucceeded)
                            .ToListAsync();
        }

        public async Task<List<Work>> getByWeekly()
        {

            return await context.Works?
                            .Where(i => i.isWeekly == true)
                            .ToListAsync();
        }

    }
}