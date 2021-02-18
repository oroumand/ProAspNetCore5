using System.ComponentModel.DataAnnotations.Schema;
namespace Session04.ConfigDb
{
    [NotMapped]
    public class NotMappedAttr
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
