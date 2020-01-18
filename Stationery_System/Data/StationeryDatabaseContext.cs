using Stationery_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stationery_System.Data
{
    public class StationeryDbContext : DbContext
    {
        public StationeryDbContext() : base("Server=LAPTOP-D8M9D5K7;Database=stationeryDB;Integrated Security=True")
        {
            System.Data.Entity.Database.SetInitializer(
                new StationeryDbInitializer<StationeryDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }

        public DbSet<AdjustmentVoucher> AdjustmentVouchers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}