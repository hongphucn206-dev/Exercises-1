using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Celsius → Fahrenheit
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(c * 9 / 5 + 32);

            // Fahrenheit → Celsius
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine((f - 32) * 5 / 9);
        }
    }
}
