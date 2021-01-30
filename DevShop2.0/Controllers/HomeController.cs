using DevShop2.Models;
using DevShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevShop2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public HomeController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CoursesOfTheWeek = _courseRepository.CoursesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
