using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Library_Test.Entities; 
using System.Threading.Tasks;

namespace Library_Test.Interface
{
    public interface IUser
    { 
        IEnumerable<dynamic> GetBooksByMostRecentActivity(Guid UserId);
        IEnumerable<dynamic> Add(Users user); 
        IEnumerable<dynamic> CheckInBooks(Users user);
        IEnumerable<Users> GetExpectedCheckOut(CheckIn user); 
    }
}
