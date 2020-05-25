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

        public async Task OnGetAsync(string peopleFilter, string tagFilter, string locationFilter)
        {
            if(peopleFilter == null)
                peopleFilter = "";
            if (locationFilter == null)
                locationFilter = "";
            if (tagFilter == null)
                tagFilter = "";
            PhotoServiceClient ps = new PhotoServiceClient();
            photos = new List<Photo>();
            var allPhotos = await ps.FilterPhotosAsync("", "", "", "", "", "");
            foreach(var ph in allPhotos)
            {
                var photo = new Photo();
                photo.Name = ph.Name;
                photo.TagList = ph.TagList;
                photo.LocationList = ph.LocationList;
                photo.PeopleList = ph.PeopleList;
                photo.Path = ph.Path;
                photos.Add(photo);
            }
            photos = photos.Where(p => p.PeopleList.Contains(peopleFilter)).ToList();
            photos = photos.Where(p => p.TagList.Contains(tagFilter)).ToList();
            photos = photos.Where(p => p.LocationList.Contains(locationFilter)).ToList();
            photos.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
        }
    }
}
