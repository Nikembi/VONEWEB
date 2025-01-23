using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VONEWEB.Models;

namespace VONEWEB.Data
{
    public class VONEDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        DbSet<User> users { get; set; }
        DbSet<Customer> customers { get; set; }
        DbSet<Order> orders { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<OrderItem> ordersItems { get; set; }
        DbSet<Transaction> transactions { get; set; }
        DbSet<CartItem> cartTrans { get; set; }
        
        
        public VONEDbContext(DbContextOptions<VONEDbContext> options) 
            : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Call the base class implementation
            base.OnModelCreating(modelBuilder);


            // Change Identity table names
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "Users");

                entity.Property(e => e.ProfilePictureUrl)
                    .HasMaxLength(500)
                    .IsRequired(false);

                entity.Property(u => u.Role)
                    .HasConversion<string>()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<IdentityRole<Guid>>(entity =>
            {
                entity.ToTable(name: "Roles");
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<Guid>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<Guid>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }
    }
}
