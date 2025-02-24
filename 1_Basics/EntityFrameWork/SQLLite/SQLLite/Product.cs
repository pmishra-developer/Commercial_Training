using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLite
{
    public class Product : DbContext
    {
        public DbSet<Customer> Customers {  get; set; }

        public string Databasepath {  get; }

        public Product() 
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);

            Databasepath = Path.Combine(path, "products.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"DataSource={Databasepath}");
        }
    }
}
