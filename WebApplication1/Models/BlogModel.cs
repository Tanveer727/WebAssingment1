using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BlogModel
    {
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string Content { get; set; }
        public AuthorModel Author { get; set; }
        public DateTime Date { get; set; }
    }
}
