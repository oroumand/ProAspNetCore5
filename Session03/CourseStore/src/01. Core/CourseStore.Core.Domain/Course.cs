using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Course
    {
        //public Course(int id,string title)
        //{
        //    Title = title;

        //    Id = id;

        //}
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public List<CourseTeacher> CourseTeachers { get; set; } = new List<CourseTeacher>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
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


    //public class LazyCoursePro
    //{
    //    public LazyCoursePro(ILazyLoader lazyLoader)
    //    {
    //        this.lazyLoader = lazyLoader;
    //    }
    //    public LazyCoursePro(Action<object, string> lazyLoader)
    //    {
    //        lazyLoader1 = lazyLoader;
    //    }
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public int Price { get; set; }
    //    public string Description { get; set; }
    //    public  Discount Discount { get; set; }

    //    private List<Tag> tags;
    //    private readonly ILazyLoader lazyLoader;
    //    private readonly Action<object, string> lazyLoader1;

    //    public List<Tag> Tags
    //    {
    //        get
    //        {
    //            lazyLoader.Load(this, "Tags");

    //            return tags;
    //        }
    //        set
    //        {
    //        }
    //    }
    //    public  List<CourseTeacher> CourseTeachers { get; set; }
    //    public  List<Comment> Comments { get; set; }
    //}
}
