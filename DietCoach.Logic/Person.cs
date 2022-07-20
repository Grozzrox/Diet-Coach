using System.Text;

namespace DietCoach.Logic
{

    public class Person
    {


        string? firstname;
        string? lastname;
        string? username;
        string password = "pass";

        public Person()
        { }

        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = firstname + "1";
            this.password = this.password + "123";
        }

       /* public string Introduce()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hello there, my name is {this.firstname} {this.lastname} and my username is {this.username} and pass: {this.password}.");
            return sb.ToString();
        }
       */

        public string Login()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please enter your username: ");
                string? usr = Console.ReadLine();

                if (usr == this.username)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid login. Please try again.");

                }
            }
            StringBuilder str = new StringBuilder();
            str.Append($"Welcome, {this.firstname}.");
            return str.ToString();

        }

    }

}

