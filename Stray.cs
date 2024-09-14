using System;

namespace sTRAYApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lost App!");
            Console.Write("Are you lost? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
                Console.WriteLine("Okay!");
            else if (response == "no")
                Console.WriteLine("Great to hear that you're not lost!");
            else
                Console.WriteLine("Invalid response. Please answer 'yes' or 'no'.");
            Console.ReadLine();
        }
    }
}
