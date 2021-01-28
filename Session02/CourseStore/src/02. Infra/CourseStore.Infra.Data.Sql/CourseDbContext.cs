using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CourseStore.Infra.Data.Sql
{
    public class CourseDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasQueryFilter(c => c.IsDeleted == false);
            base.OnModelCreating(modelBuilder);
        }
    }
}
