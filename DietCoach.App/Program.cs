using System;
using DietCoach.Logic;

namespace DietCoach.App
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
                Console.WriteLine("1: Create an Account");
                Console.WriteLine("2: Login");
                Console.WriteLine("3: Get Data");
                Console.WriteLine("0: Exit.");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("What is your first name?");
                        string? firstname = Console.ReadLine();

                        Console.WriteLine("What is your last name?");
                        string? lastname = Console.ReadLine();

                        Person p2 = new Person(firstname, lastname);
                        Login l1 = new Login(p2.username, p2.password);

                        Console.WriteLine(p2.Login());
                        
                        loop = false;
                        break;
                    case "2":
                        loop = false;
                        break;
                    case "3":
                        loop = false;
                        break;
                    case "0":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu.");
                        break;
                }
            }
            Console.WriteLine("Thank you for using Diet Coach!");
        }

    }
}