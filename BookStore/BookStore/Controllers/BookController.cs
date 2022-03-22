using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBook()
        {
            return "All Books";
        }
        public string GetBook(int id)
        {
            return $"Ramayana Book with id ={id}" ;
        }
        public string SearchBook(string BookName,string AuthorName)
        {
            return $"Book with Name ={BookName} & Book with author = {AuthorName}";
            //https://localhost:44361/book/SearchBook?BookName=bhagat&AuthorName=koshari
        }
    }
}
