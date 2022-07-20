using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace DietCoach.Logic
{
    public class Login
    {
        public int week;
        public double weight;
        public string goal;
        public int calories;
        public double carbs;
        public double fat;
        public double protein;

        public Login(int week, double weight, string goal, int calories, double carbs, double fat, double protein)
        {
            this.week = week;
            this.weight = Math.Round(weight);
            this.goal = goal;
            this.calories = calories;
            this.carbs = Math.Round(carbs);
            this.fat = Math.Round(fat);
            this.protein = Math.Round(protein);
        }

        public static Login l1 = new Login(5, 215, "maintain", 2500, 313, 79, 135);

        public string Data()
        {
            Login l2 = new Login(1, 220, "gain", 3000, 375, 100, 150);
            Login l3 = new Login(2, 222, "lose", 3250, 406, 108, 163);
            Login l4 = new Login(3, 221, "lose", 2750, 344, 92, 138);
            Login l5 = new Login(4, 217, "lose", 2500, 313, 79, 135);

            var table = new ConsoleTable("week", "weight (lbs)", "goal", "calories", "carbs (g)", "fat (g)", "protein (g)");
            table.AddRow(l2.week, l2.weight, l2.goal, l2.calories, l2.carbs, l2.fat, l2.protein)
                .AddRow(l3.week, l3.weight, l3.goal, l3.calories, l3.carbs, l3.fat, l3.protein)
                .AddRow(l4.week, l4.weight, l4.goal, l4.calories, l4.carbs, l4.fat, l4.protein)
                .AddRow(l5.week, l5.weight, l5.goal, l5.calories, l1.carbs, l5.fat, l5.protein)
                .AddRow(l1.week, l1.weight, l1.goal, l1.calories, l1.carbs, l1.fat, l1.protein);

            table.Write();
            Console.WriteLine();

            Console.WriteLine("What was your weigh-in this week?");
            int weight = Int32.Parse(Console.ReadLine());

            Login l6 = new Login(6, weight, "maintain", 2700, 330, 84, 137);

            table.AddRow(l6.week, l6.weight, l6.goal, l6.calories, l6.carbs, l6.fat, l6.protein);

            table.Write();
            Console.WriteLine();

            Console.WriteLine("Current goal = 'maintain'. Keep current fitness goal?");

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("1: Keep goal");
                Console.WriteLine("2: Lose weight");
                Console.WriteLine("3: Gain weight");
                Console.WriteLine("0: Exit.");
                Console.WriteLine("\n");

                string? choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        
                        if ((l1.weight - weight) >= 2)
                        {
                            Console.WriteLine("You have lost too much weight for your current goal. Your weekly calories have been increased by 200.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories + 200} Calories");
                            Console.WriteLine($"{l6.carbs + 26}g Carbs");
                            Console.WriteLine($"{l6.fat + 12}g Fat");
                            Console.WriteLine($"{l6.protein + 2}g Protein");

                            break;
                        }
                        else if ((weight - l1.weight) >= 2)
                        {
                            Console.WriteLine("You have gained too much weight for your current goal. Your weekly calories have been decreased by 200.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories - 200} Calories");
                            Console.WriteLine($"{l6.carbs - 27}g Carbs");
                            Console.WriteLine($"{l6.fat - 10}g Fat");
                            Console.WriteLine($"{l6.protein - 2}g Protein");

                            break;
                        }
                        else { Console.WriteLine("You are on target. Your macros will remain the same this week. Keep up the good work!"); }

                        loop = false;
                        break;
                    case "2":
                        if ((l1.weight - weight) < 2)
                        {
                            Console.WriteLine("You have not lost enough weight for your current goal. Your weekly calories have been decreased by 200.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories - 200} Calories");
                            Console.WriteLine($"{l6.carbs - 17}g Carbs");
                            Console.WriteLine($"{l6.fat - 5}g Fat");
                            Console.WriteLine($"{l6.protein - 2}g Protein");

                            break;
                        }
                        else if ((weight - l1.weight) >= 2)
                        {
                            Console.WriteLine("You have gained too much weight for your current goal. Your weekly calories have been decreased by 400.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories - 400} Calories");
                            Console.WriteLine($"{l6.carbs - 50}g Carbs");
                            Console.WriteLine($"{l6.fat - 12}g Fat");
                            Console.WriteLine($"{l6.protein - 2}g Protein");

                            break;
                        }
                        else { Console.WriteLine("You are on target. Your macros will remain the same this week. Keep up the good work!"); }

                        loop = false;
                        break;
                    case "3":
                        if ((weight - l1.weight) < 2)
                        {
                            Console.WriteLine("You have not gained enough weight for your current goal. Your weekly calories have been increased by 400.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories + 400} Calories");
                            Console.WriteLine($"{l6.carbs + 50}g Carbs");
                            Console.WriteLine($"{l6.fat + 12}g Fat");
                            Console.WriteLine($"{l6.protein + 2}g Protein");

                            break;
                        }
                        else if ((weight - l1.weight) > 2)
                        {
                            Console.WriteLine("You have gained too much weight for your current goal. Your weekly calories have been decreased by 200.");
                            Console.WriteLine($"New target macros:");
                            Console.WriteLine($"{l6.calories - 200} Calories");
                            Console.WriteLine($"{l6.carbs - 26}g Carbs");
                            Console.WriteLine($"{l6.fat - 12}g Fat");
                            Console.WriteLine($"{l6.protein - 2}g Protein");

                            break;
                        }
                        else { Console.WriteLine("You are on target. Your macros will remain the same this week. Keep up the good work!"); }

                        loop = false;
                        break;
                    case "0":
                        Console.WriteLine("Goodbye.");

                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu");
                        break;
                }
                loop = false;
            }
              

            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("Goal updated.");
            return sb.ToString();
        }

        /*
        public string username;
        public string pass;
        public Login(string username, string pass)
        {
            this.username = username;
            this.pass = pass;
        }

        public string verifyAccount(string username1, string username2)
        {
            bool check = username1.Equals(username2);
            return check.ToString();
        }
        */
    }
}
