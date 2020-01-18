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
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepEmployee> DepEmployees { get; set; }
        public DbSet<DepUser> DepUsers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Requisition> Requisitions { get; set; }
        public DbSet<RequisitionDetail> RequisitionDetails { get; set; }
        public DbSet<StoreEmployee> StoreEmployees { get; set; }
        public DbSet<StoreUser> StoreUsers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierItem> SupplierItems { get; set; }
        public DbSet<VoucherDetails> VoucherDetails { get; set; }

    }
}