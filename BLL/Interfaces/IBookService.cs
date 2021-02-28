using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IBookService
    {
        void AddNewBook(Book book);
        string CreateTheBooking(Book book);
        IEnumerable<Book> GetAllBooks();
    }
}
