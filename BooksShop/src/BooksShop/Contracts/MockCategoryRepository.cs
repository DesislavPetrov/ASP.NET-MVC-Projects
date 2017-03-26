using System;
using System.Collections.Generic;
using BooksShop.Contracts;
using BooksShop.Models;

namespace BooksShop
{
    internal class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryId = 1, CategoryName = "Biographies & Memoirs", Description = "Browse for biographies of leaders and notable people, or historical figures." },
                    new Category {CategoryId = 2, CategoryName = "Romance", Description = "All Romantic Books" },
                    new Category {CategoryId = 3, CategoryName = "Literature and Fiction", Description = "All Literature and Fiction Books" }
                };
            }
        }
    }
}