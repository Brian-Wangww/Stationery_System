using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stationery_System.Data
{
    public class StationeryDbInitializer<T> :
        DropCreateDatabaseIfModelChanges<StationeryDbContext>
    {
        protected override void Seed(StationeryDbContext context)
        {
            
            context.SaveChanges();

            Console.ReadLine();

            base.Seed(context);
        }
    }
}