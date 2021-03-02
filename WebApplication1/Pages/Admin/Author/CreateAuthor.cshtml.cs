using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.Admin.Author
{
    public class CreateAuthorModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }

        [FromForm]
        public AuthorModel Author { get; set; }
    }
}
