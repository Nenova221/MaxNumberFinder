using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberFinder
{
    public class MaxNumber
    {
        public static int MaxNumberFinder(int inputNumber1,  int inputNumber2)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            return Math.Max(a, b);
        }
    }
}
