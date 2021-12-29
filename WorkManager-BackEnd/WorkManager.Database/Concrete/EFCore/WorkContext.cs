using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkManager.Entity;

namespace WorkManager.Database.Concrete.EFCore
{

    public class WorkContext : DbContext
    {
        public WorkContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Work>? Works { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(
                        @""
                );
        }
        */
    }


}