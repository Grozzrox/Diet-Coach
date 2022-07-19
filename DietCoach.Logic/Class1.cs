using System.Text;

namespace DietCoach.Logic
{

    public class Person
    {


        string? firstname;
        string? lastname;
        string? username;
        string? password;

        public Person()
        { }

        public Person(string firstname, string lastname, string username, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
        }

        public string Introduce()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Hello there, my name is {this.firstname} {this.lastname} and my username is {this.username} and pass: {this.password}.");
            return sb.ToString();
        }

    }

}

