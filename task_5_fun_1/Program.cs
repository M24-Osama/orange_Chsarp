using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_fun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //1
            Console.WriteLine("Minutes to Seconds: " + MinutesToSeconds(5));

            //2
            Console.WriteLine("Increment 10: " + Increment(10));

            //3
            Console.WriteLine("First element of array: " + GetFirstElement(new int[] { 3, 5, 7 }));

            //4
            Console.WriteLine("Area of Triangle: " + TriangleArea(5, 10));

            //5
            int[] nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            int[] result = evenNumberEvenIndex(nums);
            Console.WriteLine(string.Join(",", result));

            //6
            string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
            string[] resultStrings = evenIndexOddLength(strings);
            Console.WriteLine("Strings with odd length at even index: " + string.Join(",", resultStrings));

            //7
            int[] nums1 = { 44, 5, 4, 3, 2, 10 };
            int[] resultNums = powerElementIndex(nums1);
            Console.WriteLine("Elements powered by their index: " + string.Join(",", resultNums));

            //8
            Console.WriteLine("multiplication2(5,4): " + multiplication2(5, 4));
            Console.WriteLine("multiplication2(2,8): " + multiplication2(2, 8)); 
            Console.WriteLine("multiplication2(7,6): " + multiplication2(7, 6)); 

            // 9
            Console.WriteLine("muti2(4,5): " + muti2(4, 5)); 
            Console.WriteLine("muti2(3,6): " + muti2(3, 6)); 

            // 10
            Console.WriteLine("aveArray([1,2,3,8,9]): " + aveArray(new int[] { 1, 2, 3, 8, 9 }));

            Console.WriteLine("aveArray([1,2,3,8,9,77]): " + aveArray(new int[] { 1, 2, 3, 8, 9, 77 }));

            Console.ReadLine();
        }

        static int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        static int Increment(int number)
        {
            return number + 1;
        }

        static int GetFirstElement(int[] arr)
        {
            if (arr.Length > 0) 
            {
                return arr[0];
            }
            throw new ArgumentException("Array is empty");
        }

        static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }
        static int[] evenNumberEvenIndex(int[] arr)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && i % 2 == 0)
                {
                    res.Add(arr[i]);
                }
            }
            return  res.ToArray();
        }
        static string[] evenIndexOddLength(string[] arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0 && arr[i].Length % 2 != 0) 
                {
                    result.Add(arr[i]);
                }
            }
            return result.ToArray();
        }

        static int[] powerElementIndex(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = (int)Math.Pow(arr[i], i); 
            }
            return result;
        }
        static int multiplication2(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < Math.Abs(b); i++)
            {
                result += a;
            }
            if (b < 0)
            {
                result = -result;
            }
            return  result; 
        }
        static int muti2(int a, int b)
        {
            int result = 1;
            for (int i = a; i <= b; i++)
            {
                result *= i;
            }
            return result;
        }

        static double aveArray(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
