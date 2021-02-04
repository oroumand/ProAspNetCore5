using Microsoft.EntityFrameworkCore;
using System;

namespace CourseStore.Infra.Data.Sql
{
    public static class ContextFactory
    {
        public static CourseDbContext GetSqlContext()
        {
            var builder = new DbContextOptionsBuilder<CourseDbContext>();
            builder
                .UseSqlServer("server=.,1833; Database = CourseStore; User Id= sa; Password=1qaz!QAZ"//,
                  //c => c.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
              )
                .LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information);
                //.UseLazyLoadingProxies();
            return new CourseDbContext(builder.Options);
        }
    }
}
