using BLL.Interfaces;
using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddNewBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public string CreateTheBooking(Book book)
        {
            var message = "You have booked" + book.Name + " - " + book.Author;
            return message;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }
    }
}
