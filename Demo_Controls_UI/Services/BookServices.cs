using Demo_Controls_UI.Models;
using Demo_Controls_UI.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Controls_UI.Services
{
    public class BookServices
    {
        private BookRepositories _Repo;
        private List<Book> _lstBooks;
        public BookServices()
        {
            _Repo = new BookRepositories();
            _lstBooks = new List<Book>();
            GetData();
        }
        public List<Book> GetBooks()
        {
            GetData();
            return _lstBooks;
        }
        public void GetData()
        {
            _lstBooks = _Repo.GetAllBook();
        }

        public string AddBook(Book book)
        {
            _Repo.AddBook(book);
            return "Add Book thành công !";
        }
        public string UpdateBook(Book book)
        {
            _Repo.UpdateBook(book);
            return "update book thành công";
        }
        public string DeleteBook(int id)
        {
            var book = _lstBooks.Where(book => book.BookId == id).FirstOrDefault();
            _Repo.DeleteBook(book);
            return "Delete Book thành công";
        }
    }
}
