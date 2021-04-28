using System.Collections.Generic;

namespace RestApis.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }


    }
}
