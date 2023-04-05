using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace WebAPIServer.Data
{
    public class CryptoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public CryptoDbContext(DbContextOptions<CryptoDbContext> options) 
            : base(options) 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CryptoCurrencyDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User(){Id = 1, Name = "Bob", },
                new User(){Id = 2, Name = "Tom", }
                );
        }
    }
}
