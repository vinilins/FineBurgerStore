using Microsoft.EntityFrameworkCore;

namespace ProjectStore.Data
{
    public class FineBurgerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                @"Server=localhost;Database=FineBurger2;User=root;Password=pcgamer2700;TreatTinyAsBoolean=true;");
        }
    }
}
