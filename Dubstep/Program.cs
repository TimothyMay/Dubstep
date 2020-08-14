using System;

namespace Dubstep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dubstep:");

            var dubstep = Console.ReadLine();
            Console.WriteLine(SongDecoder(dubstep));
            Console.ReadLine();
        }

        public static string SongDecoder(string input)
        {
            input = input.Replace("WUB", " ");
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            return input.Trim();
        }
    }
}
