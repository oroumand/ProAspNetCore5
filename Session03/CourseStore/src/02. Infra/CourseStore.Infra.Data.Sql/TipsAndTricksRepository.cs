using CourseStore.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    public static class TipsAndTricksRepository
    {
        public static void RelationShipSimple()
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.AsNoTracking().ToList();
            var discount = ctx.Set<Discount>().AsNoTracking().ToList();
        }

        public static void RelationShipNormal()
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.ToList();
            var discount = ctx.Set<Discount>().ToList();

        }
        public static void ReadEmployees()
        {
            var ctx = ContextFactory.GetSqlContext();
            var empList = ctx.Employees.Include(c => c.Children).ToList();            
        }

        public static void AddEmployees()
        {
            var ctx = ContextFactory.GetSqlContext();
            var emp = new Employee
            {
                FirstName = "FNameRoot",
                LastName = "LNameRoot",
                Children = new List<Employee>
                {
                    new Employee
                    {
                        FirstName = "Level0101",
                        LastName = "Level0101",
                        Children = new List<Employee>
                        {
                            new Employee
                            {
                                FirstName = "Level0201",
                                LastName = "Level0201"
                            },
                            new Employee
                            {
                                FirstName = "Level0202",
                                LastName = "Level0202"
                            }
                        }
                    },
                    new Employee
                    {
                        FirstName = "Level0102",
                        LastName = "Level0102"
                    }
                }
            };
            ctx.Employees.Add(emp);
            ctx.SaveChanges();
        }


        public static void AddParent()
        {
            var ctx = ContextFactory.GetSqlContext();
            var parent = new Parent
            {
                Name = "P01",
                Child01s = new List<Child01>(),
                Child02s = new List<Child02>(),
                Child03s = new List<Child03>()
            };
            for (int i = 0; i < 10; i++)
            {
                parent.Child01s.Add(new Child01
                {
                    Name = $"child{i}"
                });
                parent.Child02s.Add(new Child02
                {
                    Name = $"child{i}"
                });
                parent.Child03s.Add(new Child03
                {
                    Name = $"child{i}"
                });
            }
            ctx.Parents.Add(parent);
            ctx.SaveChanges();
        }

        public static void GetParentIncludeChild()
        {
            var ctx = ContextFactory.GetSqlContext();
            var parentQuery = ctx.Parents.Include(c => c.Child01s).Include(c => c.Child02s).Include(c => c.Child03s).AsQueryable();
            var queryText = parentQuery.ToQueryString();
            var result = parentQuery.ToList();        
        }


        public static void GetParentIncludeChildSplitedQuery()
        {
            var ctx = ContextFactory.GetSqlContext();
            var parentQuery = ctx.Parents.AsSplitQuery().Include(c => c.Child01s).Include(c => c.Child02s).Include(c => c.Child03s).AsQueryable();
            var queryText = parentQuery.ToQueryString();
            var result = parentQuery.ToList();
        }

        public static void AddChildToParent()
        {
            var ctx = ContextFactory.GetSqlContext();
            var parent = ctx.Parents
                .Include(c => c.Child01s)
                .Include(c => c.Child02s)
                .Include(c => c.Child03s)
                .Where(c=>c.Id == 1)
                .SingleOrDefault();

            for (int i = 0; i < 100; i++)
            {
                parent.Child01s.Add(new Child01
                {
                    Name = $"child{i}"
                });
                parent.Child02s.Add(new Child02
                {
                    Name = $"child{i}"
                });
                parent.Child03s.Add(new Child03
                {
                    Name = $"child{i}"
                });
            }
            ctx.SaveChanges();


        }


        public static void Detached()
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.FirstOrDefault();
            Console.WriteLine(ctx.Entry(course).State);
            ctx.ChangeTracker.Clear();
            Console.WriteLine(ctx.Entry(course).State);
        }

        public static void UseMultipleContext()
        {
            Course course;
            Discount discount;
            var ctx = ContextFactory.GetSqlContext();
            course = ctx.Courses.FirstOrDefault();
            using (var tempCtx = ContextFactory.GetSqlContext())
            {
                discount = tempCtx.Set<Discount>().FirstOrDefault();
            }
        }

        public static void CheckAddEntity()
        {
            var ctx = ContextFactory.GetSqlContext();

            var course = ctx.Courses.FirstOrDefault(c=>c.Id == 1);
            var discoutn = new Discount
            {
                CourseId = 2,
                Course = course,
                Name = "Discount02",
                NewPrice = 10
            };

            ctx.Add(discoutn);
            int a = 1;

        }

        public static void CopyCourse(int courseId)
        {
            var ctx = ContextFactory.GetSqlContext();
            var course = ctx.Courses.AsNoTrackingWithIdentityResolution()
                .Include(c => c.Discount)
                .Include(c => c.Comments)
                .Include(c => c.Tags)
                .Include(c => c.CourseTeachers)
                .FirstOrDefault(c => c.Id == courseId);

            //set id =0;
            ctx.Add(course);
            ctx.SaveChanges();
        }

        public static void DeleteDiscount(int id)
        {
            var ctx = ContextFactory.GetSqlContext();
            //var discount = ctx.Set<Discount>().FirstOrDefault(c => c.Id == id);
            var discount = new Discount
            {
                Id = id
            };
            ctx.Remove(discount);
        }
    }
}
