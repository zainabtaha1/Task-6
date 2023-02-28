using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 5
            Console.WriteLine(" Enter the first number ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the second number ");
            int secondnumber = int.Parse(Console.ReadLine());
            int result;
            result = firstnumber + secondnumber;
            Console.WriteLine(" The first number is :" + firstnumber);
            Console.WriteLine(" The second number is :" + secondnumber);
            Console.WriteLine(" The result is :" + result);
            Console.WriteLine(" The summation of {0} and {1} = {2}", firstnumber, secondnumber, result);
        }
    }
}
