using ObjectWCF.ObjectWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace HostWCF
{
    class Host
    {
        
            /*
              documentatie utilizata : www.docs.microsoft.com
            */
            static void Main(string[] args)
            {
                Uri baseAddress = new Uri("http://localhost:3005/photoAPI");


                using (ServiceHost host = new ServiceHost(typeof(PhotoService), baseAddress))
                {

                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                    host.Description.Behaviors.Add(smb);


                    host.Open();

                    Console.WriteLine("The service is ready at {0}", baseAddress);
                    Console.WriteLine("Press <Enter> to stop the service.");
                    Console.ReadLine();


                    host.Close();
                }
            }
        
    }
}
