using Microsoft.EntityFrameworkCore;
using Session01.BeginingEfCore5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.BeginingEfCore5.DataAccess
{
    public class DataClass
    {
        public static void WriteCourse()
        {
            var course = new Course
            {
                Title = "ASP.NET Core 5",
                Price = 100,
                Tags = new List<Tag>
                {
                    new Tag
                    {
                        Name = ".ENT"
                    },
                    new Tag{
                        Name="Programming"
                    }
                }
            };

            var ctx = new BeginingEfCore5Context();

            ctx.Courses.Add(course);

            ctx.SaveChanges();
        }
        public static void Update(int id, string title)
        {
            var ctx = new BeginingEfCore5Context();
            var course = ctx.Courses.Find(id);
            course.Title = title;
            ctx.SaveChanges();
        }
        public static void ReadAllCourse()
        {
            var ctx = new BeginingEfCore5Context();
            var coursesQuery = ctx.Courses.AsNoTracking().Include(c => c.Tags).AsQueryable();
            var coursesQueryText = ctx.Courses.AsNoTracking().Include(c => c.Tags).ToQueryString();
            var courses = coursesQuery.ToList();

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id}: {course.Title}, {course.Price}");
                Console.WriteLine("".PadLeft(100,'-'));
            }
        }
    }
}
