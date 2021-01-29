using DevShop2.Models;
using DevShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevShop2.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CourseController(ICourseRepository courseRepository, ICategoryRepository categoryRepository)
        {
            _courseRepository = courseRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Course> courses;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                courses = _courseRepository.AllCourses.OrderBy(p => p.CourseId);
                currentCategory = "All courses";
            }
            else
            {
                courses = _courseRepository.AllCourses.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CourseId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CoursesListViewModel
            {
                Courses = courses,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var course = _courseRepository.GetCourseById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }
    }
}
