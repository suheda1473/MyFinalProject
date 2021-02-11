using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {   //abstract virtual method
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   //sql server ın IP si örnek olarak @"Server=175.45.2.12"
            //@ ile ters \ algılıyor yazmasak \\ yapmak gerekirdi
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
