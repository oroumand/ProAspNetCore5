using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session04.ConfigDb.Configs
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(c => c.LastName).HasField("_myBackingFieldForLastName");
            //builder.Property<string>("StudnetNumber").HasField("_studentNumber");
            builder.Property<int>("InsertBy");
            builder.Property<DateTime>("InsertDate");
            builder.Property<int>("UpdateBy");
            builder.Property<DateTime>("UpdateDate");
        }
    }
}
