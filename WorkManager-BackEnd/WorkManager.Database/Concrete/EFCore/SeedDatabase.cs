using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkManager.Entity;

namespace WorkManager.Database.Concrete.EFCore
{
    public class SeedDatabase
    {
       /* public static void seed()
        {
            var dbContext = new WorkContext();

            if (dbContext.Database.GetPendingMigrations().Count() == 0)
            {
                if (dbContext.Works.Count() == 0)
                {
                    dbContext.Works.AddRange(works);
                    dbContext.SaveChanges();
                }
            }

            dbContext.SaveChanges();
        }*/

        public static Work[] works ={
            new Work(){
            name="Read Book",description="Read the software design book.",isMonthly=false,isWeekly=false,isDaily=true,isSucceeded=true,addedTime=DateTime.Now
            },
            new Work(){
            name="Code Something",description="Code with PHP Framework",isMonthly=false,isWeekly=true,isDaily=false,isSucceeded=true,addedTime=DateTime.Now
            },
            new Work(){
            name="Debug Front-End project",description="Debug React projects some bugs.",isMonthly=false,isWeekly=false,isDaily=true,isSucceeded=false,addedTime=DateTime.Now
            },
            new Work(){
            name="Write document to Rest-Api",description="Write and send Email for RestApi Back-End project.",isMonthly=false,isWeekly=true,isDaily=false,isSucceeded=false,addedTime=DateTime.Now
            },
            new Work(){
            name="Learn Mongo DB",description="Learn on udemy some NoSQL DB technologies",isMonthly=true,isWeekly=false,isDaily=false,isSucceeded=false,addedTime=DateTime.Now
            }
        };
    }
}