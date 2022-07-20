using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace DietCoach.Logic
{
    public class Goal
    {
        public double weight;
        public string sex;
        public string goal;
        public int calories;
        public double carbs;
        public double fat;
        public double protein;

        public Goal(double weight, string sex, string goal, int calories, double carbs, double fat, double protein)
        {
            this.weight = weight;
            this.sex = sex;
            this.goal = goal;
            this.calories = calories;
            this.carbs = carbs;
            this.fat = fat;
            this.protein = protein;

        }

        public static Goal g1 = new Goal(190, "male", "lose", 2500, 313, 83, 125);

        public string goalCheck()
        {
            Console.WriteLine("What is your fitness goal?");

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("1: Gain weight");
                Console.WriteLine("2: Lose weight");
                Console.WriteLine("3: Maintain weight");
                Console.WriteLine("0: Exit.");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("What is your sex?");
                        string? ansForSex = Console.ReadLine();

                        Console.WriteLine("What is your current weight in pounds?");
                        double ansForWeight = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("About how many calories do you eat in a day?");
                        int ansForCals = Int32.Parse(Console.ReadLine());
                        ansForCals += 250;

                        Goal g2 = new Goal((ansForWeight / 2.2), ansForSex, "gain", ansForCals, ((ansForCals * .50)/4), ((ansForCals * .30)/9), ((ansForCals * 0.2)/4));

                        Console.WriteLine($"Weight: {g2.weight}kg");
                        Console.WriteLine($"Sex: {g2.sex}");
                        Console.WriteLine($"Goal: {g2.goal}");
                        Console.WriteLine($"Total calories: {g2.calories}");
                        Console.WriteLine($"Carbs: {g2.carbs} g");
                        Console.WriteLine($"Fat: {g2.fat} g");
                        Console.WriteLine($"Protein: {g2.protein} g");

                        loop = false;
                        break;
                    case "2":
                        Console.WriteLine("What is your sex?");
                        ansForSex = Console.ReadLine();

                        Console.WriteLine("What is your current weight in pounds?");
                        ansForWeight = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("About how many calories do you eat in a day?");
                        ansForCals = Int32.Parse(Console.ReadLine());
                        ansForCals -= 250;

                        Goal g3 = new Goal((ansForWeight / 2.2), ansForSex, "lose", ansForCals, ((ansForCals * .50) / 4), ((ansForCals * .30) / 9), ((ansForCals * 0.2) / 4));

                        Console.WriteLine($"Weight: {g3.weight}kg");
                        Console.WriteLine($"Sex: {g3.sex}");
                        Console.WriteLine($"Goal: {g3.goal}");
                        Console.WriteLine($"Total calories: {g3.calories}");
                        Console.WriteLine($"Carbs: {g3.carbs} g");
                        Console.WriteLine($"Fat: {g3.fat} g");
                        Console.WriteLine($"Protein: {g3.protein} g");
                        loop = false;
                        break;
                    case "3":
                        Console.WriteLine("What is your sex?");
                        ansForSex = Console.ReadLine();

                        Console.WriteLine("What is your current weight in pounds?");
                        ansForWeight = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("About how many calories do you eat in a day?");
                        ansForCals = Int32.Parse(Console.ReadLine());

                        Goal g4 = new Goal((ansForWeight / 2.2), ansForSex, "maintain", ansForCals, ((ansForCals * .50) / 4), ((ansForCals * .30) / 9), ((ansForCals * 0.2) / 4));

                        Console.WriteLine($"Weight: {g4.weight}kg");
                        Console.WriteLine($"Sex: {g4.sex}");
                        Console.WriteLine($"Goal: {g4.goal}");
                        Console.WriteLine($"Total calories: {g4.calories}");
                        Console.WriteLine($"Carbs: {g4.carbs} g");
                        Console.WriteLine($"Fat: {g4.fat} g");
                        Console.WriteLine($"Protein: {g4.protein} g");
                        loop = false;
                        break;
                    case "0":
                        var table = new ConsoleTable("weight (lbs)", "sex", "goal", "calories", "carbs (g)", "fat (g)", "protein (g)");
                        table.AddRow(g1.weight, g1.sex, g1.goal, g1.calories, g1.carbs, g1.fat, g1.protein);

                        table.Write();
                        Console.WriteLine();

                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select an option from the menu.");
                        break;
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("Thank you for using Diet Coach. See you later!");
            return sb.ToString();
        }
    }
}
