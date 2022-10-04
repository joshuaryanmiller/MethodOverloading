using System;
using System.Linq;

namespace MethodOverloading
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        static string Add(int x, int y, bool isCheck)
        {
            if (isCheck == true && (x + y == 1 || x + y == -1))
            {
                return $"{x + y} dollar";
            }
            else if (isCheck == true && x + y != 1)
            {
                return $"{x + y} dollars";
            }
            else
            {
                return $"{x + y}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"First add method: {Add(15, 43)}" +
                           $"\nDecimal add method: {Add(12.3m, 5.4m)}" +
                           $"\nThird add method: {Add(4, 7, true)} {Add(-2, 1, true)} {Add(9, 6, false)}");
        }
    }
}
