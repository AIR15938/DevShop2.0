using System.Collections.Generic;
using System.Linq;

namespace DevShop2.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Course> AllCourses =>
            new List<Course>
            {
                new Course {CourseId = 1, Name="C#", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Category = _categoryRepository.AllCategories.ToList()[0], InStock=true, IsCourseOfTheWeek=false, },
                new Course {CourseId = 2, Name="Java", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[1], InStock=true, IsCourseOfTheWeek=false, },
                new Course {CourseId = 3, Name="CSS & HTML", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[0], InStock=true, IsCourseOfTheWeek=true, },
                new Course {CourseId = 4, Name="Bootstrap", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Category = _categoryRepository.AllCategories.ToList()[2], InStock=true, IsCourseOfTheWeek=true, },
            };

        public IEnumerable<Course> CoursesOfTheWeek { get; }

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(p => p.CourseId == courseId);
        }
    }
}
