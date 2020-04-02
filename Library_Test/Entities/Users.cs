using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library_Test.Entities
{
    [Table("Users", Schema = "dbo")]
    public class Users
    {
        [Key] 
        public Guid UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string NationalIdentificationNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime DateOfCheckout { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime ExpectedDateOfReturn { get; set; }

        public bool HasReturnedBook { get; set; } = false;
        [Required]
        public Guid BookId { get; set; }


    }
}
