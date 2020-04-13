using MyPhotos.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoAPI.API
{
    class PeopleAPI
    {
        public static void AddPerson(string firstName, string lastName, string photos, Model1Container context)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            context.People.Add(person);
            context.SaveChanges();
            AddPersonToPhotos(person, photos, context);
        }

        private static void AddPersonToPhotos(Person person, string photos, Model1Container context)
        {
            string[] photoList = photos.Split(' ');
            foreach(string photo in photoList)
            {
                Photo photoImage = context.Photos.Where(p => p.Name.ToLower().Equals(photo)).FirstOrDefault();
                if(photoImage != null)
                {
                    photoImage.People.Add(person);
                    context.SaveChanges();
                }
            }
        }


    }
}
 