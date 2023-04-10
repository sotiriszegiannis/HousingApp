using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class AppDbContext : IdentityDbContext
    {
        ITenantResolver tenantResolver { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options, ITenantResolver tenantResolver) : base(options) {
            ChangeTracker.QueryTrackingBehavior =QueryTrackingBehavior.NoTracking;
            ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string tenantId= tenantResolver?.GetCurrentTenantId();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(e => e.TenantId).IsRequired();

            modelBuilder.Entity<User>().HasQueryFilter(e => e.TenantId == tenantId);
        }
    }
}
