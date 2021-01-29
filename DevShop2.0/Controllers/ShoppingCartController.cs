using DevShop2.Models;
using DevShop2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevShop2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICourseRepository courseRepository, ShoppingCart shoppingCart)
        {
            _courseRepository = courseRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();       
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel   
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()    
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int courseId)
        {
            var selectedCourse = _courseRepository.AllCourses.FirstOrDefault(p => p.CourseId == courseId);

            if (selectedCourse != null)
            {
                _shoppingCart.AddToCart(selectedCourse, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int courseId)
        {
            var selectedCourse = _courseRepository.AllCourses.FirstOrDefault(p => p.CourseId == courseId);

            if (selectedCourse != null)
            {
                _shoppingCart.RemoveFromCart(selectedCourse);
            }
            return RedirectToAction("Index");
        }
    }
}
