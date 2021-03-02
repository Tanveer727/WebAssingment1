using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Models;

namespace WebApplication1.Pages.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public BlogModel Blog { get; set; }
        private List<AuthorModel> Authors { get; set; } = new List<AuthorModel>();
        public IEnumerable<SelectListItem> AuthorList { get; private set; }

        public CreateBlogModel()
        {
            AuthorModel a = new AuthorModel()
            {
                Name = "Richard",
                Last = "Brown",
                Email = "richbro@lotsofbooks.com"
            };
            AuthorModel b = new AuthorModel()
            {
                Name = "Polly",
                Last = "Town",
                Email = "polto@ireadbooks.com"
            };
            AuthorModel c = new AuthorModel()
            {
                Name = "Jimmy",
                Last = "John",
                Email = "jimjo@writingbooks.com"
            };
            Authors.Add(a);
            Authors.Add(b);
            Authors.Add(c);
        }

        public void OnGet()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var author in Authors)
            {
                list.Add(new SelectListItem(author.Name, author.Last));
            }
            AuthorList = list;
        }

        public void OnPost()
        {
            
        }
    }
}
