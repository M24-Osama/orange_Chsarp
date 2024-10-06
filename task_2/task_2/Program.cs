using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("The numbers are smaller");
            }
            Console.WriteLine("Enter a number:");
            int n3 = int.Parse(Console.ReadLine());
            if (n3 > 0)
            {
                Console.WriteLine("The sign is +");
            }
            else if (n3 < 0)
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine("The sign is zero");
            }

            Console.WriteLine("Enter three numbers:");

            int[] n4 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                n4[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(n4);
            Console.WriteLine("Sorted numbers: {0}, {1}, {2}", n4[0], n4[1], n4[2]);

            Console.WriteLine("Enter five numbers:");

            int[] n5 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                n5[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = n5[0];
            foreach (int number in n5)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The maximum number is: {max}");


            Console.WriteLine("Input kilometers per hour:");
            double kmPerHour = Convert.ToDouble(Console.ReadLine());

            double milesPerHour = kmPerHour * 0.621371;
            Console.WriteLine($"{kmPerHour} km/h is equivalent to {milesPerHour} miles per hour.");

            Console.WriteLine("Input hours:");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;
            Console.WriteLine($"Total: {totalMinutes} minutes.");

            Console.WriteLine("Input total minutes:");
            int totalM = Convert.ToInt32(Console.ReadLine());

            int h = totalM / 60;
            int m = totalM % 60;

            Console.WriteLine($"{h} Hours, {m} Minutes");

            string[] str1 = {
            "Osama,",
            "my old:",
            "22,",
            "I am learning C# programming",
            "code."
            };
            string str2 = string.Join(" ", str1);
            Console.WriteLine(str2);

            Console.WriteLine(reverseOdd("One two three four"));
            Console.WriteLine(reverseOdd("Bananas"));

            Console.ReadLine();
        }

        static string reverseOdd(string sentence)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    Console.WriteLine(charArray);
                    words[i] = new string(charArray);
                }
            }

            return string.Join(" ", words);
        }
    }
}
