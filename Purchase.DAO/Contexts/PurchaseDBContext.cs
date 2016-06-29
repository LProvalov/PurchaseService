using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Purchase.DAO.Models;

namespace Purchase.DAO
{
    public class PurchaseDBContext : DbContext
    {
        public PurchaseDBContext() : base("name=PurchaseDB") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commodity>().HasKey<int>(c => c.Id);
        }

        public DbSet<Commodity> Commodities { get; set; }
    }
}
