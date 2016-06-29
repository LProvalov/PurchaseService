using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using PurchaseService.Models;

namespace PurchaseService.Contexts
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}