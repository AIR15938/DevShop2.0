using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevShop2.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
        new List<Category>
        {
                new Category{CategoryId=1, CategoryName="Front-End", Description="The visual elements "},
                new Category{CategoryId=2, CategoryName="Back-End", Description="The logic behind"},
                new Category{CategoryId=3, CategoryName="TBD", Description="To be Determined"}
        };
    }
}
