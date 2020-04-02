using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Test.Entities
{
    public class BookTest
    {
         

        public string Title { get; set; } = String.Empty;
         
        public string Isbn { get; set; }= String.Empty;

        public string PublishYear { get; set; } = String.Empty;

        public double CoverPrice { get; set; }

        public string AvailabilityStatus { get; set; }= String.Empty;
    }
}
