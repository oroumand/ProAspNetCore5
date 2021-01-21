using System.Collections.Generic;

namespace Session01.BeginingEfCore5.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
