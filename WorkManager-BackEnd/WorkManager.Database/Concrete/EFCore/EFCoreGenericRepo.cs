using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkManager.Database.Abstract;

namespace WorkManager.Database.Concrete.EFCore
{
    public class EFCoreGenericRepo<TEntity> : IRepo<TEntity>
        where TEntity : class

    {
        protected readonly DbContext context;

        public EFCoreGenericRepo(DbContext ctx)
        {
            this.context = ctx;
        }
        public async Task create(TEntity entity)
        {

            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();

        }

        public async Task delete(TEntity entity)
        {

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

        }

        public async Task<List<TEntity>> getAll()
        {
            return await context.Set<TEntity>().ToListAsync();

        }

        public async Task<TEntity> getById(int id)
        {

            return await context.Set<TEntity>().FindAsync(id);

        }

        public async Task update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();

        }
    }
}