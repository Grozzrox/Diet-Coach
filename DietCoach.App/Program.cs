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
                Console.WriteLine("0: Exit.");
                Console.WriteLine("\n");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("What is your first name?");
                        string? firstname = Console.ReadLine();

                        Console.WriteLine("What is your last name?");
                        string? lastname = Console.ReadLine();

                        Person p2 = new Person(firstname, lastname);

                        Console.WriteLine("\n");
                        Console.WriteLine("Account created.");
                        Console.WriteLine("\n");
                        Console.WriteLine(p2.Login(p2.username, p2.password));

                        Console.WriteLine(Goal.g1.goalCheck());
                        
                        loop = false;
                        break;
                    case "2":
                        Console.WriteLine(Person.p1.Login(Person.p1.username, Person.p1.password));
                        
                        Console.WriteLine(Login.l1.Data());
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
            Console.WriteLine("\n");
        }

    }
}