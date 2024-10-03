using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int n = 1;
            string s1 = "Osama";
            double d = 3.14;
            float f = 3.5555f;
            bool b = true;
            const int i = 0;

            Console.WriteLine(n + " " + s1 + " " + d + " " + f + " " + b + " " + i);

            string[] car = { "BMW", "Mercedes", "Audi" , "Porsche"};
            Console.WriteLine(car.Length);

            Console.WriteLine("Enter a first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter a birth day:");
            string birth = Console.ReadLine();


            Console.WriteLine(firstName + " " + lastName + " " + birth);

            int[] arr = { 1,1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (var a in arr)
            {
                Console.WriteLine(a);

            }
            int sum = 0;
            foreach (var a in arr)
            {
                sum += a;
            }
            Console.WriteLine("Sum of all elements stored in the array is: "+sum);
        }
    }
}
