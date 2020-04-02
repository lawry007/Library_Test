using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Library_Test.Entities;

namespace Library_Test.Interface
{
    public interface IBook<T>
    {
        IEnumerable<BookTest> GetAllBooks();
        IEnumerable<Books> SearchForBooks(string bookDetails); 
        IEnumerable Add(Books book);
    }
}
