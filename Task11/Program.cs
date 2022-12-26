using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            var equation = new Equation(k, b);
            Console.WriteLine(equation.Root());
            Console.ReadKey();
        }
    }
}
