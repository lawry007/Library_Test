using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Test.Entities
{
    public class CheckIn
    {
        public Guid UserId { get; set; } 
        public Guid BookId { get; set; }  
    }
}
