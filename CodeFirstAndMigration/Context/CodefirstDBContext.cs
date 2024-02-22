using CodeFirstAndMigration.Entities;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstAndMigration.Context
{
    public class CodefirstDBContext : DbContext //DbContext microsoftEfCore 'dan kalıtım alıyoruz
    {

        public DbSet<Customer> Customers { get; set; } //Tablolar
        public DbSet<Product> Products { get; set; } //Tablolar

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P7KA77K\\SQLEXPRESS;Database=CodefirstDB;User Id=sa;Password=1234; ;TrustServerCertificate=true");
        }

    }
}
