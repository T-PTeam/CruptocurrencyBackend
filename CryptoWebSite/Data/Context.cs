using CryptoWebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoWebSite.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> opts) : base(opts)
        {
            Database.EnsureCreated();
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
    
}
