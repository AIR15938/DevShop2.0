using DevShop2.Models;
using DevShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;

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


        public IActionResult List()
        {

            CoursesListViewModel coursesListViewModel = new CoursesListViewModel();
            coursesListViewModel.Courses = _courseRepository.AllCourses;

            coursesListViewModel.CurrentCategory = "Courses"; //titel
            return View(coursesListViewModel);
        }
    }
}
