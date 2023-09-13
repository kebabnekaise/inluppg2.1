using System;

namespace inluppg2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din favoritbok?");
            string namn = Console.ReadLine();
            Console.WriteLine($"{namn}");
        }
    }
}