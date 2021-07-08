using Microsoft.AspNetCore.Mvc;
using Session18.ViewComponentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session18.ViewComponentSample.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepository courseRepository;

        public CoursesController(ICourseRepository courseRepository)

        {
            this.courseRepository = courseRepository;
        }
        public IActionResult Index()
        {
            return View(courseRepository.GetCourses());
        }
    }
}
