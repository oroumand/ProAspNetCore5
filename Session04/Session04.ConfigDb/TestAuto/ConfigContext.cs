using Microsoft.EntityFrameworkCore;
using System;

namespace Session04.ConfigDb
{
    public class ConfigContext:DbContext
    {
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.,1833; Database=ConfigDb2;User Id=sa;Password=1qaz!QAZ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(c =>
            {
                c.Property(d => d.FirstName).HasMaxLength(50);
                c.Property(d => d.LastName).HasMaxLength(50);
            });
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.ClrType).Property<int>("AutoShadow");

                foreach (var entityProperty in entityType.GetProperties())
                {
                    if (entityProperty.ClrType == typeof(DateTime)
                    && entityProperty.Name.EndsWith("Utc"))
                    {
                        //entityProperty.SetValueConverter();
                    }
                }

            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
