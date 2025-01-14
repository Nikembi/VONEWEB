using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VONEWEB.Data
{
    public class VONEDbContext : IdentityDbContext
    {

        
        public VONEDbContext(DbContextOptions<VONEDbContext> options) 
            : base(options) 
        { }

    }
}
