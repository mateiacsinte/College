using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorView.Models;

using PhotoService;

namespace RazorView.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Photo> photos;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            PhotoServiceClient ps = new PhotoServiceClient();
            photos = new List<Photo>();
            var allPhotos = await ps.FilterPhotosAsync("", "", "", "", "", "");
            foreach(var ph in allPhotos)
            {
                var photo = new Photo();
                photo.Name = ph.Name;
                photos.Add(photo);
            }
           
            var p1 = new Photo();
            p1.Name = "Prima Fotografie";
            var p2 = new Photo();
            p2.Name = "Fotografia 2";
            photos.Add(p1);
            photos.Add(p2);
            

        }
    }
}
