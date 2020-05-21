using MyPhotoAPI.API;
using MyPhotos.Context;
using System.Collections.Generic;
using System.Linq;


namespace MyPhotoAPI
{
    public sealed class PhotoAPI
    {
        Model1Container context;
        public PhotoAPI()
        {
           context = new Model1Container();
        }

        public void AddPhoto(string photoName, string photoPath, string photoLocations, string photoTags, string photoDate)
        {
            Photo photo = new Photo();
            photo.Name = photoName;
            photo.Path = photoPath;
            photo.Date = photoDate;
            List<Tags> tags = TagAPI.GetPhotoTags(photoTags, context);
            List<Location> locations = LocationAPI.GetPhotoLocations(photoLocations, context);
            foreach(Tags tag in tags)
            {
                photo.Tags.Add(tag);
            }
            foreach(Location location in locations)
            {
                photo.Locations.Add(location);
            }
            context.Photos.Add(photo);
            context.SaveChanges();
        }

        public void UpdatePhoto(string name, string newName, string newPath, string newLocation, string newTags, string newDate)
        {
            Photo currentPhoto = context.Photos.Where(p => p.Name.Equals(name)).FirstOrDefault();
            Photo newPhoto = new Photo();
            if (newName.Equals(""))
            {
                newPhoto.Name = currentPhoto.Name;
            }
            else
            {
                newPhoto.Name = newName;
            }
            if (newPath.Equals(""))
            {
                newPhoto.Path = currentPhoto.Path;
            }
            else
            {
                newPhoto.Path = newPath;
            }
            if (newDate.Equals(""))
            {
                newPhoto.Date = "";
            }
            else
            {
                newPhoto.Date = currentPhoto.Date;
            }
            if (newLocation.Equals(""))
            {
                newPhoto.Locations = currentPhoto.Locations;
            }
            else
            {
                List<Location> locations = LocationAPI.GetPhotoLocations(newLocation, context);
                foreach (Location location in locations)
                {
                    newPhoto.Locations.Add(location);
                }
            }
            if (newTags.Equals(""))
            {
                newPhoto.Tags = currentPhoto.Tags;
            }
            else
            {
                List<Tags> tags = TagAPI.GetPhotoTags(newTags, context);
                foreach(Tags tag in tags)
                {
                    newPhoto.Tags.Add(tag);
                }
            }
            context.Photos.Add(newPhoto);
            context.Entry(currentPhoto).Collection("Tags").Load();
            context.Entry(currentPhoto).Collection("Locations").Load();
            context.Entry(currentPhoto).Collection("People").Load();
            context.Photos.Remove(currentPhoto);
            context.SaveChanges();
        }
        public void DeletePhotos(string photoName, string photoLocation, string photoTag)
        {
            if (!photoName.Equals(""))
            {
                Photo photo = context.Photos.Where(p => p.Name.ToLower().Equals(photoName)).FirstOrDefault();
                context.Entry(photo).Collection("Tags").Load();
                context.Entry(photo).Collection("Locations").Load();
                context.Entry(photo).Collection("People").Load();
                context.Photos.Remove(photo);
                context.SaveChanges();
            }
            if (!photoLocation.Equals(""))
            {
                IEnumerable<Photo> photos = context.Photos.ToList();
                foreach(Photo photo in photos)
                {
                    foreach (Location location in photo.Locations.ToList())
                        if (location.Name.ToLower().Equals(photoLocation))
                            RemovePhoto(photo);
                            
                }
            }
            if (!photoTag.Equals(""))
            {
                IEnumerable<Photo> photos = context.Photos.ToList();
                foreach(Photo photo in photos)
                {
                    foreach(Tags tag in photo.Tags)
                    {
                        if (tag.Description.ToLower().Equals(photoTag))
                            RemovePhoto(photo); 
                    }
                }
            }
        }

        public void AddLocations(string photoName, string locationsList)
        {
            List<Location> locations = LocationAPI.GetPhotoLocations(locationsList, context);
            Photo photo = context.Photos.Where(p => p.Name.ToLower().Equals(photoName)).FirstOrDefault();
            foreach(Location location in locations)
            {
                photo.Locations.Add(location);
                context.SaveChanges();
            }
        }

        public void AddTags(string photoName, string tagList)
        {
            List<Tags> tags = TagAPI.GetPhotoTags(tagList, context);
            Photo photo = context.Photos.Where(p => p.Name.ToLower().Equals(photoName)).FirstOrDefault();
            foreach(Tags tag in tags)
            {
                photo.Tags.Add(tag);
                context.SaveChanges();
            }
        }

        private void RemovePhoto(Photo photo)
        {
            context.Entry(photo).Collection("Tags").Load();
            context.Entry(photo).Collection("Locations").Load();
            context.Photos.Remove(photo);
            context.SaveChanges();
        }

        public void AddPerson(string firstName, string lastName, string photos)
        {
            PeopleAPI.AddPerson(firstName, lastName, photos, context);
        }

        public IEnumerable<Photo> FilterPhotos(string photoName, string person, string path, string location, string tag, string date)
        {
            IEnumerable<Photo> allPhotos = context.Photos.ToList();
            if (!photoName.Equals(""))
            {
                return context.Photos.Where(p => p.Name.ToLower().Equals(photoName)).ToList();
            }
            if (!path.Equals(""))
            {
                return context.Photos.Where(p => p.Path.ToLower().Equals(path)).ToList();
            }

            if (!date.Equals(""))
            {
                return context.Photos.Where(p => p.Date.ToLower().Equals(date)).ToList();
            }

            if (!location.Equals(""))
            {
                List<Photo> chosenPhotos = new List<Photo>();
               
                foreach(Photo currentPhoto in allPhotos)
                {
                    foreach(Location currentLocation in currentPhoto.Locations)
                    {
                        if (currentLocation.Name.ToLower().Equals(location))
                            chosenPhotos.Add(currentPhoto);
                    }
                }
                return chosenPhotos;
            }

            if (!person.Equals(""))
            {
                List<Photo> chosenPhotos = new List<Photo>();
                foreach (Photo currentPhoto in allPhotos)
                {
                    foreach (Person currentPerson in currentPhoto.People)
                    {
                        if (currentPerson.FirstName.ToLower().Equals(person))
                            chosenPhotos.Add(currentPhoto);
                    }
                }
                return chosenPhotos;
            }

            if (!tag.Equals(""))
            {
                List<Photo> chosenPhotos = new List<Photo>();
                
                foreach(Photo currentPhoto in allPhotos)
                {
                    foreach(Tags currentTag in currentPhoto.Tags)
                    {
                        if (currentTag.Description.ToLower().Equals(tag))
                            chosenPhotos.Add(currentPhoto);
                    }
                }
                return chosenPhotos;
            }
            return allPhotos;
        }
    } 
}
