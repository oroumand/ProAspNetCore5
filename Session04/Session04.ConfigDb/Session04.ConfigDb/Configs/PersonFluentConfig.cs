using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using Session04.ConfigDb.Infra;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Session04.ConfigDb.Configs
{
    public enum WeekDays
    {
        Shanbe,
        YekShanbe,
        DoShanbe,
        SeShanbe,
        ChaharShanbe,
        PanjShanbe,
        Jomeh
    }
    public class PersonFluentConfig : IEntityTypeConfiguration<PersonFluent>
    {
        public void Configure(EntityTypeBuilder<PersonFluent> builder)
        {
            builder.ToTable("FluentPerson");
            builder.Ignore(c => c.FullName);
            //builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            //builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.PersonType).HasConversion<string>().HasMaxLength(50);
            
            
            var valueConvertor = new ValueConverter<NationalCode, string>(n => n.Value, s => new NationalCode(s));
            
            
            builder.Property(c => c.NationalCode).HasConversion(valueConvertor);

            builder.Property(c => c.Name).HasConversion(c => JsonConvert.SerializeObject(c),
                s => JsonConvert.DeserializeObject<PersonName>(s));

            builder.Property(c => c.EncriptedText).HasConversion(new EncryptedConverter());
            builder.Property(c => c.BirthDate).HasColumnName("DateOfBirth");
            builder.HasIndex(c => new { c.Age, c.BirthDate});
            //builder.Property(p => p.BirthDate)./*IsRequired().HasMaxLength(*/50);

        }
    }
}
