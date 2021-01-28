using DevShop2.Models;
using System.Collections.Generic;

namespace DevShop2.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Course> CoursesOfTheWeek { get; set; }
    }
}
