using CourseStore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    public static class CommandRepository
    {

        public static void CheckEntityState()
        {
            var ctx = ContextFactory.GetSqlContext();
            var teacher = new Teacher
            {
                FirstName = "Masoud",
                LastName = "Taheri"
            };
            ctx.Add(teacher);
            Console.WriteLine($"Teacher State Is : {ctx.Entry(teacher).State}");
            var course = ctx.Courses.FirstOrDefault();

            Console.WriteLine($"Course State Before Change Is: {ctx.Entry(course).State}");

            course.Title = "Pro Ef And ASP.NET Core";

            Console.WriteLine($"Course State Before Change Is:  {ctx.Entry(course).State}");

            ctx.Remove(course);

            Console.WriteLine($"Course State After Remove Is:  {ctx.Entry(course).State}");

            var tag = new Tag
            {
                Title = "New Tag"
            };

            Console.WriteLine($"Tag State :  {ctx.Entry(tag).State}");
        }

        public static void ChangeTrackerState()
        {
            var ctx = ContextFactory.GetSqlContext();
            var teacher = new Teacher
            {
                FirstName = "Masoud",
                LastName = "Taheri"
            };
            ctx.Add(teacher);

            var course = ctx.Courses.FirstOrDefault();

            //ctx.Entry(course).Property(c => c.Title).CurrentValue = "Pro Ef And ASP.NET Core";
            course.Title = "Pro Ef And ASP.NET Core";

            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);
            ctx.Remove(course);


            var tag = new Tag
            {
                Title = "New Tag"
            };

        }

        public static void CreateCourse(string title, string description, int price)
        {
            var course = new Course
            {
                Title = title,
                Description = description,
                Price = price
            };

            var ctx = ContextFactory.GetSqlContext();
            //ctx.Add(course);
            ctx.Courses.Add(course);
            ctx.SaveChanges();
        }

        public static void CreateCourseWithDiscount(string title, string description, int price, int discountPrice, string discountTitle)
        {
            var course = new Course
            {
                Title = title,
                Description = description,
                Price = price,
                Discount = new Discount
                {
                    Name = discountTitle,
                    NewPrice = discountPrice
                }
            };

            var ctx = ContextFactory.GetSqlContext();
            //ctx.Add(course);
            ctx.Courses.Add(course);
            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);
            ctx.SaveChanges();
            Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);

        }

        public static void Update(int courseId, string newTitle)
        {
            var ctx = ContextFactory.GetSqlContext();
            //var course1 = ctx.Courses.Find(courseId);
            // var course2 = ctx.Courses.FirstOrDefault(c=>c.Id == courseId);
            var course = ctx.Courses.SingleOrDefault(c => c.Id == courseId);
            course.Title = newTitle;
            ctx.SaveChanges();
        }

        public static void ShowForUpdateDisconnected(int courseId)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.SingleOrDefault(c => c.Id == courseId);

            Console.WriteLine($"{course.Id}: {course.Title} {Environment.NewLine} {course.Description}");

            UpdateDisconnected(courseId, "New Title");
        }

        private static void UpdateDisconnected(int courseId, string title)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.SingleOrDefault(c => c.Id == courseId);
            course.Title = title;
            ctx.SaveChanges();
        }


        public static void ShowForUpdateDisconnectedTag(int tagId)
        {
            var ctx = ContextFactory.GetSqlContext();
            var tag = ctx.Tags.SingleOrDefault(c => c.Id == tagId);

            Console.WriteLine($"{tag.Id}: {tag.Title}");

            UpdateDisconnectedTag(tag.Id, "New Title");
        }

        private static void UpdateDisconnectedTag(int id, string title)
        {
            var ctx = ContextFactory.GetSqlContext();
            var tag = new Tag
            {
                Id = id,
                Title = title
            };
            ctx.Tags.Update(tag);
            ctx.SaveChanges();

        }

        public static void SoftDelete(int courseId)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.SingleOrDefault(c => c.Id == courseId);
            course.IsDeleted = true;
            ctx.SaveChanges();
        }

        public static void Delete(int courseId)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.SingleOrDefault(c => c.Id == courseId);
            ctx.Courses.Remove(course);
            ctx.SaveChanges();
        }
    }
}
