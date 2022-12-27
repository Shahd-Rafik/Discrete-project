using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the secound number:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", x, y);
            for (int i = x; i <= y; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
