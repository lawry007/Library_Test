using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Test.Entities
{
    public class CheckOut
    {
        public Guid UserId { get; set; } 
        public string FullName { get; set; } 
        public string Email { get; set; } 
        public string PhoneNumber { get; set; } 
        public string NationalIdentificationNumber { get; set; } 
        public DateTime DateOfCheckout { get; set; } 
        public DateTime ExpectedDateOfReturn { get; set; }
    }
}
