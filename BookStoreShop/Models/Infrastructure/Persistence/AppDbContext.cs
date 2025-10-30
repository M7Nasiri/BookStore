using BookStoreShop.Models.Domain.Entities.BookAgg;
using BookStoreShop.Models.Domain.Entities.CategoryAgg;
using Microsoft.EntityFrameworkCore;

namespace BookStoreShop.Models.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-6U51JF85\SQL2022;Database=Maktab135_HW_17;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
