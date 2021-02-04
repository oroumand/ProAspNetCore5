using Microsoft.EntityFrameworkCore;
using System;

namespace Migration
{
    public class Person
    {
        public int Id { get; set; }
        //public string FirtName { get; set; }
        //public string LastName { get; set; }

        public string FullName { get; set; }

    }
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.,1833; Database = CourseStore; User Id= sa; Password=1qaz!QAZ");
            base.OnConfiguring(optionsBuilder);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
