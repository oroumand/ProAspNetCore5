using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Models
{

    public class Course
    {
        public string CourseName { get; set; }
        public DateTime StartDate { get; set; }
    }

    public interface ICourseRepository
    {
        List<Course> GetCourses();
    }

    public class InMemoryCourseReposiotry : ICourseRepository
    {
        private List<Course> courses = new List<Course>
        {
            new Course{CourseName = "Pro ASP.NET Core 5", StartDate = DateTime.Now.AddMonths(-6)},
            new Course{CourseName = "Software Architecture", StartDate = DateTime.Now.AddMonths(3)},

        };
        public List<Course> GetCourses()
        {
            return courses;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }

    public interface IPersonRepository
    {
        List<Person> GetPeople();
        int TotalCount();
    }

    public class InmemoryPersonRepository : IPersonRepository
    {
        private List<Person> people = new List<Person>
        {
            new Person{FirstName="Alireza",LastName = "Oroumand",BirthDate =DateTime.Now.AddYears(-50)},
            new Person{FirstName="Mohammad",LastName = "Lotfi",BirthDate =DateTime.Now.AddYears(-1500)},
            new Person{FirstName="Omid",LastName = "Ghorbani",BirthDate =DateTime.Now.AddYears(-60)},
            new Person{FirstName="Farid",LastName = "Taheri",BirthDate =DateTime.Now.AddYears(-90)},
            new Person{FirstName="Shahin",LastName = "Moghadam",BirthDate =DateTime.Now.AddYears(-100)}
        };
        public List<Person> GetPeople()
        {
            return people;
        }

        public int TotalCount()
        {
            return people.Count;
        }
    }
}
