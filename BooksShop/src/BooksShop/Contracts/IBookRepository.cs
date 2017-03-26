using BooksShop.Models;
using System.Collections.Generic;

namespace BooksShop.Contracts
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> BooksOfTheWeek { get; }
        Book GetBookById(int bookId);
    }
}
