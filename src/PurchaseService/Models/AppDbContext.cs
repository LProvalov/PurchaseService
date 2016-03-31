using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace PurchaseService.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}