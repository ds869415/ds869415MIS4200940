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

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}