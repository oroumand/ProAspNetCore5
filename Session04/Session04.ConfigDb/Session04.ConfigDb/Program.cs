using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Session04.ConfigDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new ConfigContext();
            var student = ctx.Set<Student>().First();

            var insertBy = ctx.Entry(student).Property<int>("InsertBy");
            ctx.Entry(student).Property<int>("InsertBy").CurrentValue = 2;
            ctx.Set<Student>().OrderBy(b => EF.Property<DateTime>(b, "UpdatedDate")).ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
