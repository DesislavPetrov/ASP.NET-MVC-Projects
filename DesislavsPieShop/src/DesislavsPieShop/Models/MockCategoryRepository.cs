using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesislavsPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
