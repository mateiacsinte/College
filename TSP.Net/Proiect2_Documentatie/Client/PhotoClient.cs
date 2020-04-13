
namespace MyPhotosClient
{
    namespace ClientPhotoService
    {
       
        public class PhotoClient
        {
            public PhotoServiceClient photoService;
            public PhotoClient()
            {
                photoService = new PhotoServiceClient();
            }

        }
    }
}
