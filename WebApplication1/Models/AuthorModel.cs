using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AuthorModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Last { get; set; }
        public DateTime DOB { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please provide an Email address.")]
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Website { get; set; }
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(20)]
        public string Country { get; set; }
        [MaxLength(20)]
        public string Province { get; set; }
        [MaxLength(20)]
        public string Pincode { get; set; }
    }
}
