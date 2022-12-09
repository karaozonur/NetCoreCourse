using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Nugettan Microsoft.EntityFrameworkCore.SqlServer
        {
            //optionsBuilder.UseSqlServer(connectionString: @"Server:.;Database=Northwind;Trusted_Connection=true");


            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
            /*         .UseSqlServer(connectionString: @"Data Source='NIRVANASERVER';Initial Catalog='Northwind';Integrated Security=True;Persist Security Info=True;User ID='sa';Password='1234';User Instance=False");*/
            ;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasNoKey();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
