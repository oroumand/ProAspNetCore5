using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Session01.BeginingEfCore5.Models;
using System;

namespace Session01.BeginingEfCore5.DataAccess
{
    public class BeginingEfCore5Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.,1733; Database=BeginingEfCore5Db; User Id=sa; Password=1qaz!QAZ")
                .LogTo(Console.WriteLine,LogLevel.Information);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
