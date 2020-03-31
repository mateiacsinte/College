using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2.Contracts
{
    [ServiceContract]
    public interface IPhotoService

    {
        [OperationContract]
        void AddPhoto(string photoName, string photoPath, string photoLocations, string photoTags, string photoDate);

        [OperationContract]
        void UpdatePhoto(string name, string newName, string newPath, string newLocation, string newTags, string newDate);

        [OperationContract]
        void DeletePhotos(string photoName, string photoLocation, string photoTag);
        
        [OperationContract]
        void AddLocations(string photoName, string locationsList);

        [OperationContract]
        void AddTags(string photoName, string tagList);

        [OperationContract]
        void RemovePhoto(Photo photo);

        [OperationContract]
        void AddPerson(string firstName, string lastName, string photos);

        [OperationContract]
        IEnumerable<Photo> FilterPhotos(string photoName, string person, string path, string location, string tag, string date);
    }
}
