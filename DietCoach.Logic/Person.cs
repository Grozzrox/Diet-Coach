using System.Text;

namespace DietCoach.Logic
{

    public class Person
    {


        public string? firstname;
        public string? lastname;
        public string? username;
        public string password = "pass";

        public Person()
        { }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = firstname + "1";
            this.password = this.password + "123";
        }

        public static Person p1 = new Person("Andrew", "Grozdanov");

        

        /* public string Introduce()
         {
             StringBuilder sb = new StringBuilder();
             sb.Append($"Hello there, my name is {this.firstname} {this.lastname} and my username is {this.username} and pass: {this.password}.");
             return sb.ToString();
         }
        */

        public string Login(string user, string userpass)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter your username: ");
                string? usr = Console.ReadLine();

                if (usr == user)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid username. Please try again.");

                }
            }
            loop = true;
            while(loop)
            {
                Console.WriteLine("Please enter your password: ");
                string? pass = Console.ReadLine();

                if (pass == userpass)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid password.");
                }
            }
            StringBuilder str = new StringBuilder();
            str.Append($"Welcome, {firstname}.");
            return str.ToString();

        }

    }

}

