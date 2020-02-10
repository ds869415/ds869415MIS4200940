using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ds869415MIS4200940.Models;


namespace ds869415MIS4200940.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,ds869415MIS4200940.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        public DbSet<Pets> Pets { get; set; }

        public DbSet<vet> Vet { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}