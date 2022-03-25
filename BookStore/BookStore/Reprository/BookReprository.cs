using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Reprository
{
    public class BookReprository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<BookModel>SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id =1,Title ="MVS",Author="nitesh"},
                new BookModel(){ Id =2,Title ="Dot new Core",Author="Shubham"},
                new BookModel(){ Id =3,Title ="Python",Author="Praav"},
                new BookModel(){ Id =4,Title ="C#",Author="Apu"},
                new BookModel(){ Id =5,Title ="C++",Author="Tapu"},
                new BookModel(){ Id =6,Title ="English",Author="Jhapuu"},
            };
        }
    }
}
