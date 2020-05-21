using MyPhotosDb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1Container context = new Model1Container())
            {
                Location l = new Location();
                l.Name = "Romania";
                context.Locations.Add(l);
                Photo p = new Photo();
                p.Date = "26.01.1988";
                p.Name = "My New Photo";
                p.Path = "C://Users//MyPhoto";
                p.Locations.Add(l);

                context.Photos.Add(p);
                context.SaveChanges();
            }
        }
    }
}
