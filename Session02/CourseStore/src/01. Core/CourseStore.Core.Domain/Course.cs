using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public List<Tag> Tags { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
        public List<Comment> Comments { get; set; }
        public bool IsDeleted { get; set; }
    }

    //public class LazyCourse
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public int Price { get; set; }
    //    public string Description { get; set; }
    //    public virtual Discount Discount { get; set; }
    //    public virtual List<Tag> Tags { get; set; }
    //    public virtual List<CourseTeacher> CourseTeachers { get; set; }
    //    public virtual List<Comment> Comments { get; set; }
    //}
}
