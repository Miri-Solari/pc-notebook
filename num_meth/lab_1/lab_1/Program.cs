using System;

namespace lab_1
{
    class Program
    {
        static double F(double x)
        {
            return x * x * x - 2 - Math.Log(x + 2);
        }
        static void Main(string[] args)
        {
            double a, b, x0, x1, E;
            Console.WriteLine("Input a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b ");
            b = Convert.ToDouble(Console.ReadLine());
            x0 = (a + b) / 2;
            Console.WriteLine("Input E");
            E = Convert.ToDouble(Console.ReadLine());
            while (a - b > E)
            {

            }

        }
    }
}
