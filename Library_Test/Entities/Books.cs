using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Test.Entities
{
    [Table("Books", Schema = "dbo")]
    public class Books
    {
        [Key]
        public Guid BookId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(20)]
        public string Isbn { get; set; }
        [Required]
        [MaxLength(10)]
        public string PublishYear { get; set; }
        [Required] 
        public double CoverPrice { get; set; } 
        [Required]
        [MaxLength(50)]
        public string AvailabilityStatus { get; set; } 
    }
}
