using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session04.ConfigDb.Configs
{
    public class PersonFluentPkConfig : IEntityTypeConfiguration<PersonFluentPk>
    {
        public void Configure(EntityTypeBuilder<PersonFluentPk> builder)
        {
            builder.HasKey(c => new { c.MyPrimaryKey01, c.MyPrimaryKey02 });
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);


        }
    }
}
