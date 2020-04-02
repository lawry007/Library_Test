using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using dataAccess.Entities;

namespace dataAccess.Interface
{
    public interface IBook
    {
        IEnumerable<Books> GetAllBooks();
    }
}
