using GameHub.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace GameHub.ProductAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebAPIDatabase"));
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        //FluentAPI
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //category
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);

            modelBuilder.Entity<Category>().
                Property(c => c.Name).
                HasMaxLength(100).
                IsRequired();

            modelBuilder.Entity<Category>().
                HasMany(p => p.Products).
                WithOne(c => c.Category).
                IsRequired();

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Ação"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Luta"
                }
                );

            //product
            modelBuilder.Entity<Product>().
                Property(p => p.Name).
                HasMaxLength(100).
                IsRequired();

            modelBuilder.Entity<Product>().
                Property(p => p.Description).
                HasMaxLength(255).
                IsRequired();

            modelBuilder.Entity<Product>().
                Property(p => p.ImageURL).
                HasMaxLength(255).
                IsRequired();

            modelBuilder.Entity<Product>().
                Property(p => p.Price).
                HasPrecision(12,2).
                IsRequired();

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "The Witcher 3: Wild Hunt",
                    Price = 76.86M,
                    Description = "Em The Witcher 3, Geralt de Rivia embarca em uma jornada perigosa e emocionante em um mundo repleto de monstros e intrigas.",
                    Stock = 50,
                    ImageURL = "TheWitcher3.png",
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    Name = "Street Fighter V",
                    Price = 23.00M,
                    Description = "Street Fighter V: A batalha épica de lutadores habilidosos em busca da supremacia.",
                    Stock = 5,
                    ImageURL = "StreetFighterV.png",
                    CategoryId = 2,
                }
                );
        }
    }
}
