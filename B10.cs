using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{years} {weeks} {remainingDays}");
        }
    }
}
