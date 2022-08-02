using Demo_Controls_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Controls_UI.Respositories
{
    public class BookRepositories
    {
        private BooksDbContext _dbContext;
        public BookRepositories()
        {
            _dbContext = new BooksDbContext();
        }
        public List<Book> GetAllBook()
        {
            var lstBook = _dbContext.Books.ToList();
            return lstBook;
        }
        public bool AddBook(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return true;
        }
        public bool UpdateBook(Book book)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();
            return true;
        }
        public bool DeleteBook(Book book)
        {
            _dbContext.Remove(book);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
