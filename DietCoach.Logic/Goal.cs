using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietCoach.Logic
{
    public class Goal
    {
        public double? weight;
        public string? sex;
        public string? goal;
        public int? calories;
        public double? carbs;
        public double? fat;
        public double? protein;

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
                        Console.WriteLine($"Carbs: {g2.carbs}");
                        Console.WriteLine($"Fat: {g2.fat}");
                        Console.WriteLine($"Protein: {g2.protein}");

                        loop = false;
                        break;
                    case "2":
                        Console.WriteLine($"Weight: {g1.weight}kg");
                        Console.WriteLine($"Sex: {g1.sex}");
                        Console.WriteLine($"Goal: {g1.goal}");
                        Console.WriteLine($"Total calories: {g1.calories}");
                        Console.WriteLine($"Carbs: {g1.carbs}");
                        Console.WriteLine($"Fat: {g1.fat}");
                        Console.WriteLine($"Protein: {g1.protein}");
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
            return null;
        }
    }
}
