using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Session04.ConfigDb
{
    [Table("AttributePerson")]
    public class PersonAttr
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        public int Age { get; set; }
        [Column("MyBirthDate", TypeName = "DateTime")]
        
        public DateTime BirthDate { get; set; }
        public NotMappedAttr NotMappedAttr { get; set; }
    }

    public class PersonAttrPk
    {
        [Key]
        public int MyPrimaryKey { get; set; }
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
    }
}
