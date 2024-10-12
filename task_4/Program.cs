using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            // 1

            int[] numbers = new int[10];
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number-{i + 1} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            double average = (double)sum / 10;

            Console.WriteLine($"\nThe sum of 10 numbers is: {sum}");
            Console.WriteLine($"The average is: {average:F6}");

            // 2

            int num;

            Console.Write("Input number of terms: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is : {i * i * i}");
            }

            // 3

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            
            Years(years);

            // 4
            int ageInYears = 22;
            int ageInDays = ConvertAgeToDays(ageInYears);
            Console.WriteLine($"Age in days: {ageInDays}");

            // 5
            int chickens = 2; 
            int cows = 3;     
            int pigs = 5;     

            int totalLegs = CountLegs(chickens, cows, pigs);
            Console.WriteLine($"Total number of legs: {totalLegs}");

            // 6
            Console.WriteLine(Login("user1", "password1"));
            Console.WriteLine(Login("user2", "pas"));
            // 7
            Console.WriteLine(pow(2, 4));
            // 8
            Console.Write("Enter a year between 1900 and 2024: ");
            int year = Convert.ToInt32(Console.ReadLine());

            string result = CheckLeapYear(year);
            Console.WriteLine(result);

        }
        static string Login(string username, string password)
        {
            string[,] users = new string[,]
            {
            { "user1", "password1" },
            { "user2", "password2" },
            { "user3", "password3" }
            };

            for (int i = 0; i < users.GetLength(0); i++)
            {
                if (users[i, 0] == username && users[i, 1] == password)
                {
                    return "pass";
                }
            }

            return "failed";
        }
        static void Years(int[] year)
        {
            foreach (int y in year)
            {
                if (y > 1950)
                {
                    Console.WriteLine(y);
                }
            }
        }
        static int ConvertAgeToDays(int ageInYears)
        {
            return ageInYears * 365;
        }
        static int CountLegs(int chickens, int cows, int pigs)
        {
            if (chickens % 2 != 0 || cows % 2 != 0 || pigs % 2 != 0)
            {
                throw new ArgumentException("Input numbers must be even.");
            }

            int totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4);
            return totalLegs;
        }
        static int pow(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            int x = 1;
            for (int i = 0; i < b; i++)
            {
                x *= a;
            }
            return x; 
        }
        static string CheckLeapYear(int year)
        {
            if (year < 1900 || year > 2024)
            {
                return "Year is out of the valid range (1900-2024).";
            }

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return $"{year} is a leap year.";
            }
            else
            {
                return $"{year} is not a leap year.";
            }
        }
    }
}
