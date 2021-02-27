using eShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EcomDBConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
