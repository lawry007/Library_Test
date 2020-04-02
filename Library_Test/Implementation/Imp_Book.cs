using Library_Test.Entities;
using Library_Test.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Library_Test.DB_Context;
using System.Linq;

namespace Library_Test.Implementation
{
    public class Imp_Book : IBook<Books>
    {
        readonly LibraryContext _libraryContext;

        public Imp_Book(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public IEnumerable<BookTest> GetAllBooks()
        {
            return  _libraryContext.Book.Select(c => new BookTest() { Title= c.Title, Isbn=c.Isbn, PublishYear = c.PublishYear, CoverPrice=c.CoverPrice, AvailabilityStatus =c.AvailabilityStatus } ).OrderBy(c => c.PublishYear).ToList();
            
        }

        
        public IEnumerable<Books> SearchForBooks(string bookDetails)
        {
            return _libraryContext.Book.Where(c => c.Title == bookDetails || c.Isbn ==bookDetails || c.AvailabilityStatus==bookDetails).ToList();
        }
        public IEnumerable GetBooksByMostRecentActivity()
        {
            return _libraryContext.Book.Select(c => new BookTest() { Title = c.Title, Isbn = c.Isbn, PublishYear = c.PublishYear, CoverPrice = c.CoverPrice, AvailabilityStatus = c.AvailabilityStatus }).OrderBy(c => c.PublishYear).ToList();
        }

        public IEnumerable Add(Books book)
        {
            _libraryContext.Add(book);
            _libraryContext.SaveChanges();
            return null;
        }
    }
}
