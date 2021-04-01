using System;

namespace Observer_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Make creator");
            Console.WriteLine("2. Make subscriber");
            Console.WriteLine("3. Subscribe");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Creator Big_Hot_Men = new Creator();
                    break;
                case "2":
                    Console.WriteLine("Write subscriber name");
                    Subscriber subscriber = new Subscriber(Console.ReadLine());
                    break;
                case "3":
                    Big_Hot_Men.Subscribe();
                    break;
            }
        }
    }
}
