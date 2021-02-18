using Microsoft.EntityFrameworkCore;
using Session04.ConfigDb.Configs;
using System.Reflection;

namespace Session04.ConfigDb
{
    public class ConfigContext:DbContext
    {
        public DbSet<PersonConv> PersonConvs { get; set; }
        public DbSet<PersonAttr> PersonAttrs { get; set; }
        public DbSet<PersonAttrPk> PersonAttrPks { get; set; }
        public DbSet<PersonFluent> PersonFluents{ get; set; }
        public DbSet<KeylessEntity> KeylessEntities { get; set; }
        public DbSet<KeylessView> KeylessViews { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.,1833; Database=ConfigDb;User Id=sa;Password=1qaz!QAZ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("config");
            modelBuilder.Entity<NoDbSet>().Property(c => c.Name).HasMaxLength(100);
            modelBuilder.Entity<KeylessEntity>().HasNoKey();
            modelBuilder.Entity<KeylessView>().HasNoKey().ToView("vw_KeylessViews");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //if(Database.IsSqlServer())
            //{
            //    //Config SQL
            //    modelBuilder.Entity<NoDbSet>().IsMemoryOptimized();
            //}
            //else
            //{

            //}
            //if(Database.IsRelational())
            //{

            //}
            //modelBuilder.Ignore<NotMappedAttr>();

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.ClrType).Property<int>("AutoShadow");
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
