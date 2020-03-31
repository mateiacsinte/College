using IExtern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerExtern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(IExtern.Extern),
           new Uri("net.tcp://localhost:8182/extern"));
            host.Open();
            Console.WriteLine("Server extern started...");
            Console.ReadLine();
            host.Close();
        }
    }
}
