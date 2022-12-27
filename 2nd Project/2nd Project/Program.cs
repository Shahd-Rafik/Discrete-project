using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect numbers between {0} and {1} are:", x, y);
            for (int i = x; i <= y; i++)
            {
                if (IsPerfect(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        private static bool IsPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}
