using Microsoft.EntityFrameworkCore.Design;

namespace CourseStore.Infra.Data.Sql
{
    public class CourseDbContextDesignTimeFactory : IDesignTimeDbContextFactory<CourseDbContext>
    {
        public CourseDbContext CreateDbContext(string[] args)=>
            ContextFactory.GetSqlContext();
    }
}
