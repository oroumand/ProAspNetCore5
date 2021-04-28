using Microsoft.EntityFrameworkCore;

namespace RestApis.Models
{
    public class ProductApiDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Cateories { get; set; }
        public DbSet<Supplier> Suppliers{ get; set; }
        public ProductApiDbContext(DbContextOptions<ProductApiDbContext> options) : base(options)
        {
        }
    }
}
