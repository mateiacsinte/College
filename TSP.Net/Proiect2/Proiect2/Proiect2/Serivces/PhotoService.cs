using Proiect2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2.Serivces
{
    public class PhotoService : IPhotoService
    {
        public void AddLocations(string photoName, string locationsList)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(string firstName, string lastName, string photos)
        {
            throw new NotImplementedException();
        }

        public void AddPhoto(string photoName, string photoPath, string photoLocations, string photoTags, string photoDate)
        {
            throw new NotImplementedException();
        }

        public void AddTags(string photoName, string tagList)
        {
            throw new NotImplementedException();
        }

        public void DeletePhotos(string photoName, string photoLocation, string photoTag)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Photo> FilterPhotos(string photoName, string person, string path, string location, string tag, string date)
        {
            throw new NotImplementedException();
        }

        public void RemovePhoto(Photo photo)
        {
            throw new NotImplementedException();
        }

        public void UpdatePhoto(string name, string newName, string newPath, string newLocation, string newTags, string newDate)
        {
            throw new NotImplementedException();
        }
    }
}
