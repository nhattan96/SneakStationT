using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace SneakStationT.Models.DAL
{
    public class SneakStationDbContext : DbContext
    {
        public SneakStationDbContext() : base("name=SneakStationTConnection")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}