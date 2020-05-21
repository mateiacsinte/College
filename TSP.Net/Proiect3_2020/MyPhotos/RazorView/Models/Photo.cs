
using System.Collections.Generic;


namespace RazorView.Models
{
    public class Photo
    {
        public Photo() { }
        public string Name { get; set; }
        public string Path { get; set; }
        public List<string> people;
        public List<string> places;
    }
}
