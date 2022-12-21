using Microsoft.EntityFrameworkCore;

namespace VA_Prod_API.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
    }
}
