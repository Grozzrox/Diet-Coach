using System;

namespace DietCoach
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Diet Coach.");

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1: Read from file.");
                Console.WriteLine("2: Write to file.");
                Console.WriteLine("3: Create Xml Record");
                Console.WriteLine("4: Read from Xml Record");
                Console.WriteLine("0: Exit.");

                string? choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Selected option 1. Good choice ;)");
                        break;
                    case "2":
                        loop = false;
                        break;
                    case "3":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu.");
                        break;
                }
            }
            Console.WriteLine("Application closin...");
        }
    }
}