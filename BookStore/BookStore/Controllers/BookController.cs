using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Reprository;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookReprository _BookReprository = null;
        public BookController()
        {
            _BookReprository = new BookReprository();
        }
        public ViewResult GetAllBook()
        //public List<BookModel> GetAllBook()
        {
            var data= _BookReprository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _BookReprository.GetBookById(id);
            //return $"Ramayana Book with id ={id}" ;
        }
        public List<BookModel> SearchBook(string BookName,string AuthorName)
        {
            return _BookReprository.SearchBook(BookName, AuthorName);
            //return $"Book with Name ={BookName} & Book with author = {AuthorName}";
            //https://localhost:44361/book/SearchBook?BookName=bhagat&AuthorName=koshari
        }
    }
}
