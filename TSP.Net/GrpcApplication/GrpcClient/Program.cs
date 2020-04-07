﻿using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var input = new HelloRequest { Name = "Tim" };
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClinet(channel);

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
        }
    }
}
