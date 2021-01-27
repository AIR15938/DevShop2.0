using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevShop2.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Course> AllCourses =>
            new List<Course>
            {
                new Course {CourseId = 1, Name="C#", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="http://localhost:44311/images/C#.jpg",InStock=true, IsCourseOfTheWeek=false, ImageThumbnailUrl="http://localhost:44311/images/C#.jpg", },
                new Course {CourseId = 2, Name="Java", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsCourseOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Course {CourseId = 3, Name="CSS & HTML", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, IsCourseOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"},
                new Course {CourseId = 4, Name="Bootstrap", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, IsCourseOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"}
            };

        public IEnumerable<Course> CoursesOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(p => p.CourseId == courseId);
        }
    }
}
