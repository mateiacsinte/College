
using System.Collections.Generic;


namespace RazorView.Models
{
    public class Photo
    {
        public Photo() { }
        public string Name { get; set; }
        public string Path { get; set; }
        public string TagList { get; set; }
        public string PeopleList { get; set; }
        public string LocationList { get; set; }
    }
}
