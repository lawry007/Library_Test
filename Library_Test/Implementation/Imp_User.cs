using System.Collections;
using System.Collections.Generic;
using System.Text;
using Library_Test.DB_Context;
using Library_Test.Interface;
using System.Linq;
using System;
using Library_Test.Entities;
using System.Threading.Tasks;

namespace Library_Test.Implementation
{
    public class Imp_User : IUser
    {
        readonly LibraryContext _libraryContext;

        public Imp_User(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public IEnumerable<dynamic> Add(Users user)
        {
             _libraryContext.Add<Users>(user);
            _libraryContext.SaveChanges();
            return null;
        }

        public IEnumerable<dynamic> CheckInBooks(Users user)
        {
            _libraryContext.Update<Users>(user);
            _libraryContext.SaveChanges();
            return null;
        }

        public IEnumerable<dynamic> GetBooksByMostRecentActivity(Guid UserId)
        {
            try
            {
                var a = from sa in _libraryContext.User
                        join s in _libraryContext.Book on sa.BookId equals s.BookId
                        where sa.UserId == UserId
                        orderby sa.DateOfCheckout descending
                        select new { sa.FullName, sa.PhoneNumber, sa.Email, s.Title, s.Isbn, s.PublishYear, s.CoverPrice, s.AvailabilityStatus };

                return a.ToList();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public IEnumerable<Users> GetExpectedCheckOut(CheckIn user)
        {
            List<Users> result = _libraryContext.User.Where(c => c.UserId == user.UserId & c.BookId == user.BookId).ToList();
            return result;
        }
    }
}
