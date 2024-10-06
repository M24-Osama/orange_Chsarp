using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Correct the Syntax Errors
            string[] arr = { "1", "7", "9", "45" };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

            Console.WriteLine("Corrected Arrays:");
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", arr2));
            Console.WriteLine(string.Join(", ", arr3));
            Console.WriteLine();

            // 2. Find Index of "Banana" and "Tomato"
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            int indexTomato = Array.IndexOf(fruits, "Tomato");
            int indexBanana = Array.IndexOf(fruits, "Banana");

            Console.WriteLine($"Index of 'Tomato': {indexTomato}");
            Console.WriteLine($"Index of 'Banana': {indexBanana}");
            Console.WriteLine();

            // 3. Create Multiple Arrays and Print Using foreach
            string[] favoriteFood = { "Pizza", "Sushi", "Burger", "Pasta", "Tacos" };
            string[] favoriteSport = { "Soccer", "Basketball", "Tennis" };
            string[] favoriteMovie = { "Inception", "The Matrix", "Interstellar", "The Godfather" };

            Console.WriteLine("Favorite Food:");
            foreach (string food in favoriteFood)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine("\nFavorite Sport:");
            foreach (string sport in favoriteSport)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nFavorite Movie:");
            foreach (string movie in favoriteMovie)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine();

            // 4. Calculate the Sum of Three Numbers
            Console.Write("Input three numbers separated by comma: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');

            int sum = 0;
            foreach (string num in numbers)
            {
                sum += int.Parse(num.Trim());
            }

            Console.WriteLine("The sum of three numbers: " + sum);
            Console.WriteLine();

            // 5. Display Odd Numbers and Their Sum from 1 to 100
            int oddSum = 0;
            Console.Write("The odd numbers are: ");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                oddSum += i;
            }

            Console.WriteLine("\nThe Sum of odd Numbers is: " + oddSum);
            Console.WriteLine();

            // 6. Display Right Angle Triangle Using Asterisks
            int rows = 3;

            Console.WriteLine("Asterisk Pattern:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // 7. Display Right Angle Triangle with Numbers
            int number = 1;

            Console.WriteLine("Number Pattern:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
