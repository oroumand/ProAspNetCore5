using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    public static class QueryRepository
    {
        public static void AddDefaultData()
        {
            var context = ContextFactory.GetSqlContext();
            context.Courses.Where(c => c.Title == "");
            context.Courses.Add(new Course
            {
                Title = "Pro ASP.NET Core",
                Price = 100,
                Description = "Description ASP Net Core",
                Discount = new Discount
                {
                    Name = "Yalda",
                    NewPrice = 80
                },
                Comments = new List<Comment>
                {
                    new Comment
                    {
                        Title = "Comment Title",
                        CommentDate = DateTime.Now,
                        CommentText = "Comment Text"
                    }
                },
                CourseTeachers = new List<CourseTeacher>
                {
                    new CourseTeacher
                    {
                        SortOrder = 1,
                        Teacher = new Teacher
                        {
                            FirstName= "Alireza",
                            LastName = "Oroumand"
                        }
                    }
                },
                Tags = new List<Tag>
                {
                    new Tag
                    {
                        Title = "ASP.NET"
                    },
                    new Tag
                    {
                        Title = ".NET 5"
                    }
                }
            });
            context.SaveChanges();
        }


        public static void EagerLoadingSample01()
        {
            var ctx = ContextFactory.GetSqlContext();

            var query = ctx.Courses
                .Include(c => c.Discount)
                .Include(c => c.Comments)
                .Include(c => c.CourseTeachers).ThenInclude(d => d.Teacher)
                .Include(c=>c.Tags);

            var queryString = query.ToQueryString();

            var result = query.ToList();

        }

        public static void EagerLoadingSample02()
        {
            var ctx = ContextFactory.GetSqlContext();

            var query = ctx.Courses
                .Include(c => c.Discount)
                .Include(c => c.Comments.Where(c=>c.CommentDate >= DateTime.Now.AddDays(-10)))
                .Include(c => c.CourseTeachers.OrderBy(c=>c.SortOrder)).ThenInclude(d => d.Teacher)
                .Include(c => c.Tags);
            var queryString = query.ToQueryString();
            var result = query.ToList();

        }

        public static void ExplicitLoading()
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.FirstAsync();

            ctx.Entry(course).Reference("Discount").Load();

            ctx.Entry(course).Collection("Tags").Load();
        }

        public static void SelectLoading()
        {
            var ctx = ContextFactory.GetSqlContext();

            var course = ctx.Courses.Select(c=> new {
                Title = c.Title,
                Price = c.Price,
                NewPrice = c.Discount.NewPrice,
                PriceTitle = c.Discount.Name,
                CommentCount = c.Comments.Count()
            });
        }

        public static void ClientVsServerBefore3()
        {
            var ctx = ContextFactory.GetSqlContext();
            var result = ctx.Teachers.OrderBy(c => c.FullName).Skip(1000).Take(10).ToList();
        }

        public static void ClientVsServerAfter03()
        {
            var ctx = ContextFactory.GetSqlContext();
            var result = ctx.Courses.Select(c => new
            {
                Title = c.Title,
                Tags = string.Join(',',c.Tags.Select(d=>d.Title))
            });
        }

        public static void SortOrder(bool asc)
        {
            var ctx = ContextFactory.GetSqlContext();
            if (asc)
            {
                var course = ctx.Courses.OrderBy(c => c.Price).ThenBy(c=>c.Title).ToList();
            }
            else
            {
                var course = ctx.Courses.OrderByDescending(c => c.Price).ThenByDescending(c => c.Title).ToList();
            }
        }

        public static void Paging(int pageSize,int pageIndex)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.OrderBy(c => c.Title).Skip(pageIndex * pageSize).Take(pageSize);
        }

        public static void SearchText(string term)
        {
            var ctx = ContextFactory.GetSqlContext();
            var result01 = ctx.Courses.Where(c => c.Title.StartsWith(term));
            var result02 = ctx.Courses.Where(c => c.Title.Contains(term));
            var result03 = ctx.Courses.Where(c => c.Title == term);

            var result04 = ctx.Courses
                .Where(x => EF.Functions.Collate(x.Title, "Latin1_General_CS_AS") == term);


            var result05 = ctx.Courses.Where(c => EF.Functions.Like(c.Title, "The ___ sat on the %."));


        }
    }
}
