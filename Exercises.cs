using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Ex7();
            Ex8();
            Ex9();
            Ex10();
        }

        static void Ex1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }

        static void Ex2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a + " " + b);
        }

        static void Ex3()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }

        static void Ex4()
        {
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine(feet * 0.3048);
        }

        static void Ex5()
        {
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine(f);

            f = double.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }

        static void Ex6()
        {
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(bool));
        }

        static void Ex7()
        {
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine((int)ch);
        }

        static void Ex8()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(3.14159 * r * r);
        }

        static void Ex9()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine(side * side);
        }

        static void Ex10()
        {
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int d = (days % 365) % 7;
            Console.WriteLine(years + " " + weeks + " " + d);
        }
    }
}
