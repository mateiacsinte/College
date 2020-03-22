using System;
using System.Threading;

namespace Lab1
{
    class Program
    {
        static bool isPrime(int number)
        {
            if (number == 2)
                return true;
            if (number < 3)
                return false;
            if (number % 2 == 0)
                return false;
            for (int i = 3; i < number; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }

        static int firstAlgorithm(int number)
        {
            int maxPrime = 0;
            for (int i = 0; i < number; i++)
                if (isPrime(i))
                    maxPrime = i;
            Console.WriteLine("First Finished : " + maxPrime);
            return maxPrime;
        }
        static int secondAlgorithm(int number)
        {
            for (int i = number - 1; i > 2; i--)
                if (isPrime(i))
                {
                    Console.WriteLine("Second Finished : " + i);
                    return i;
                }
            Console.WriteLine("Second Finished : " + 2);
            return 2;
        }



        public delegate string BuildText(string text);
        class MyEvent {

            event BuildText ev;
            MyEvent()
            {

            }

        }





        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int valN = Int32.Parse(val);
            Thread t1 = new Thread(() => firstAlgorithm(valN));
            Thread t2 = new Thread(() => secondAlgorithm(valN));
            t1.Start();
            t2.Start();
           
        }
    }
}
