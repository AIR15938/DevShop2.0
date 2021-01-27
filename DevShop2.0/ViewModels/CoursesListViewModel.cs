using DevShop2.Models;
using System.Collections.Generic;

namespace DevShop2.ViewModels
{
    public class CoursesListViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public string CurrentCategory { get; set; }
    }
}
