using AutoMapper;
using BBooking.Models;
using BLL.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBooking.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        private IMailService _mailService;
        private IMapper _mapper;

        public BookController(IBookService bookService, IMailService mailService, IMapper mapper)
        {
            _bookService = bookService;
            _mailService = mailService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            var bookViewModels = _mapper.Map<IEnumerable<BookViewModel>>(books);

            return View(bookViewModels);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            var book = _mapper.Map<Book>(model);
            _bookService.AddNewBook(book);
            var htmlBook = _bookService.CreateTheBooking(book);
            _mailService.SendMessage(book.Email, htmlBook);

            return Redirect("Book");
        }
    }
}
