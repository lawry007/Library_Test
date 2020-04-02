using dataAccess.Entities;
using dataAccess.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text; 
namespace dataAccess.Implementation
{
    public class Imp_Book : IBook
    {
        readonly LibraryContext _libraryContext;

        public IEnumerable<Books> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}
