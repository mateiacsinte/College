using MyPhotos.Context;
using System.Collections.Generic;
using System.Linq;


namespace MyPhotoAPI
{
    public class LocationAPI
    {
        static public List<Location> GetLocations(Model1Container context)
        {
            List<Location> locations = context.Locations.ToList();
            return locations;
        }

        static public List<Location> GetPhotoLocations(string photoLocations, Model1Container context)
        {
            string[] locations = photoLocations.Split(' ');
            CreateNonExistentLocations(locations, context);
            List<Location> returnLocations = GetLocationsByList(locations, context);
            return returnLocations;
        }

        static private List<Location> GetLocationsByList(string[] locations, Model1Container context)
        {
            IEnumerable<Location> contextLocations = context.Locations.ToList();
            List<Location> returnLocation = new List<Location>();
            foreach (string location in locations)
            {
                foreach (Location contextLocation in contextLocations)
                    if (contextLocation.Name.ToLower().Equals(location.ToLower()))
                        returnLocation.Add(contextLocation);
            }
          
            
            return returnLocation;
        }
        static private void CreateNonExistentLocations(string[] locations, Model1Container context)
        {
            foreach (string location in locations)
            {
                if (!Exists(location, context))
                    CreateLocation(location, context);
            }
        }
        static private bool Exists(string locationName, Model1Container context)
        {
            List<Location> locations = GetLocations(context);
            foreach (Location location in locations)
            {
                if (location.Name.Equals(locationName))
                    return true;
            }
            return false;
        }

        static private void CreateLocation(string locationName, Model1Container context)
        {
            Location location = new Location
            {
                Name = locationName
            };
            context.Locations.Add(location);
            context.SaveChanges();
        }
    }
}
