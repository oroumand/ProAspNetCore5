using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Course> Courses { get; set; }
    }
}
