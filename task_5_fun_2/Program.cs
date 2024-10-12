using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_fun_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(getDays(new DateTime(2019, 6, 14),new DateTime(2019, 6, 20)));

            //2
            Console.WriteLine(numInStr(new string[] { "1a", "a", "2b", "b" }));
            Console.WriteLine(numInStr(new string[] { "abc", "abc10" }));

            //3
            Console.WriteLine(reverseOdd("Bananas"));
            Console.WriteLine(reverseOdd("One two three four"));

            //4
            Console.WriteLine(isPandigital(98140723568910));
            Console.WriteLine(isPandigital(90864523148909));
            Console.ReadLine();
        }
        static int getDays(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }
        static string numInStr(string[] strings) { 
            List<string> arr = new List<string>();
            bool isnum = false;
            bool ischar = false;
            for (int i = 0; i < strings.Length; i++)
            {
                isnum = false; 
                ischar = false;
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (char.IsDigit(strings[i][j]))
                    {
                        isnum = true;
                    }
                    if (char.IsLetter(strings[i][j]))
                    {
                        ischar = true;
                    }
                    if (isnum && ischar)
                    {
                        arr.Add(strings[i]);
                        break;
                    }
                }
            }
            return string.Join(" ", arr);
        }
        static string reverseOdd(string s)
        {
            string[] arr = s.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length % 2 != 0)
                {
                    arr[i] = new string(arr[i].Reverse().ToArray()); 
                }
            }
            return string.Join(" ", arr);
        }
        static bool isPandigital(long n)
        {
            List<char> arr = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            char[] s = n.ToString().ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                arr.Remove(s[i]);
            }
            return arr.Count == 0;
        }
    }
}
