using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proiect3.Pages
{
    public class FilterModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var person = Request.Form["Person"];
            var tag = Request.Form["Tag"];
            var place = Request.Form["Location"];
            var URL = $"Index?peopleFilter={person}&tagFilter={tag}&locationFilter={place}";
            return RedirectToPage(URL);
        }
    }
}