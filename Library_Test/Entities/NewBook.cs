using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Test.Entities
{
    public class NewBook
    {
        public string Title { get; set; } = String.Empty;

        public string Isbn { get; set; } = String.Empty;

        public string PublishYear { get; set; } = String.Empty;

        public decimal CoverPrice { get; set; }

        public string AvailabilityStatus { get; set; } = String.Empty;
    } 
    
}
