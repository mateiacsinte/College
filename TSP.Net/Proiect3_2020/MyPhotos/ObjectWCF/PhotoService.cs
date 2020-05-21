using MyPhotoAPI;
using MyPhotos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF.ObjectWCF
{
    public class PhotoService : IPhotoService
    {
        public void AddLocations(string photoName, string locationsList)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.AddLocations(photoName, locationsList);
        }

        public void AddPerson(string firstName, string lastName, string photos)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.AddPerson(firstName, lastName, photos);
        }

        public void AddPhoto(string photoName, string photoPath, string photoLocations, string photoTags, string photoDate)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.AddPhoto(photoName, photoPath, photoLocations, photoTags, photoDate);
        }

        public void AddTags(string photoName, string tagList)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.AddTags(photoName, tagList);
        }

        public void DeletePhotos(string photoName, string photoLocation, string photoTag)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.DeletePhotos(photoName, photoLocation, photoTag);
        }

        public IEnumerable<PhotoDTO> FilterPhotos(string photoName, string person, string path, string location, string tag, string date)
        {
            List<PhotoDTO> outPhotos = new List<PhotoDTO>();
            try
            {
                PhotoAPI pAPI = new PhotoAPI();
                IEnumerable<Photo> photos = pAPI.FilterPhotos(photoName, person, path, location, tag, date);
               
                foreach (Photo photo in photos)
                {
                    PhotoDTO photoDTO = new PhotoDTO(photo.Name, photo.Path, photo.Date);
                    outPhotos.Add(photoDTO);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return outPhotos.ToArray();
        }

      
        public void UpdatePhoto(string name, string newName, string newPath, string newLocation, string newTags, string newDate)
        {
            PhotoAPI pAPI = new PhotoAPI();
            pAPI.UpdatePhoto(name, newName, newPath, newLocation, newTags, newDate);
        }
    }
}
