using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VONEWEB.Models;

namespace VONEWEB.Data
{
    public class VONEDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        DbSet<Customer> customers { get; set; }
        DbSet<Order> orders { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<OrderItem> ordersItems { get; set; }
        DbSet<Transaction> transactions { get; set; }
        DbSet<CartItem> cartTrans { get; set; }
        
        
        public VONEDbContext(DbContextOptions<VONEDbContext> options) 
            : base(options) 
        { }

    }
}
