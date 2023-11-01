using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, fact = 1;
            Console.Write("please enter a number");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
                fact *= i;
            Console.WriteLine(string.Format("The result is: {0}",fact));
            Console.ReadLine();
        }
    }
}
