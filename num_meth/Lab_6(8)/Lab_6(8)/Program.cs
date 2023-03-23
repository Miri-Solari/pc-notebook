using System;

namespace LAB_6_8_
{
    class Program
    {
        static double F(double x)
        {
            return Math.Log(x * x + 2);
            //return Math.Sqrt(2*Math.Log(x)+1)/x;
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 100;
            double n;
            double h, answ = 0;
            Console.WriteLine("Введите количество дроблений: ");
            n = Convert.ToDouble(Console.ReadLine());
            h = (b - a) / (2*n);
            answ += F(a) + F(b);
            for (int x = 1; x < 2 * n; x ++)
            {
                //Console.WriteLine(F(x * h + a) * Math.Pow(2, 1 + x % 2));
                answ += F(x*h + a) * Math.Pow(2, 1 + x % 2);
            }
            Console.WriteLine("Результат, полученный методом Симпсона: " + Convert.ToString(h/3*answ));
        }
    }
}
