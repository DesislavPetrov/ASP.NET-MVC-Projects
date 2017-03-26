using BooksShop.Models;
using System.Collections.Generic;

namespace BooksShop.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
