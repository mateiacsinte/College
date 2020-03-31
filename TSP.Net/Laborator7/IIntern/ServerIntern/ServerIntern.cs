using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerIntern
{
    class ServerIntern
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(IIntern.Intern),
           new Uri("net.tcp://localhost:8181/intern"));
            host.Open();
            Console.WriteLine("Server intern started...");
            Console.ReadLine();
            host.Close();
        }
    }
}
