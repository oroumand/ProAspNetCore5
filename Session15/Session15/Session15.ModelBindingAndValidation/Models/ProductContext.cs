using Microsoft.EntityFrameworkCore;

namespace Session15.ModelBindingAndValidation.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(c =>
            {
                c.Property(d => d.Name).HasMaxLength(100);
                c.HasData(new Category { Id = 1, Name = "Category01" },
                    new Category { Id = 2, Name = "Category02" },
                    new Category { Id = 3, Name = "Category03" }
                    );

            });
            modelBuilder.Entity<Product>(c =>
            {
                c.Property(d => d.Name).HasMaxLength(100);
                c.Property(d => d.Description).HasMaxLength(500);

                c.HasData(
                    new Product { Id = 1, Name = "Product01", Description = "Description Product 01", Price = 1_000_000, CategoryId = 1 },
                    new Product { Id = 2, Name = "Product02", Description = "Description Product 02", Price = 2_000_000, CategoryId = 1 },
                    new Product { Id = 3, Name = "Product03", Description = "Description Product 03", Price = 3_000_000, CategoryId = 3 },
                    new Product { Id = 4, Name = "Product04", Description = "Description Product 04", Price = 4_000_000, CategoryId = 3 },
                    new Product { Id = 5, Name = "Product05", Description = "Description Product 05", Price = 5_000_000, CategoryId = 2 },
                    new Product { Id = 6, Name = "Product06", Description = "Description Product 06", Price = 6_000_000, CategoryId = 2 },
                    new Product { Id = 7, Name = "Product07", Description = "Description Product 07", Price = 7_000_000, CategoryId = 2 }

                    );

            });
        }

    }
}
