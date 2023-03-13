using System;

namespace LAB_4_6_
{
    class Program
    {
        static double F(double x)
        {
            return Math.Log(x * x + 2);
        }
        static double SRect(double h, double y)
        {
            return y*h;
        }


        static void Main(string[] args)
        {
            double a = 50;
            double b = 100;
            double n;
            double h, answ = 0;

            Console.WriteLine("Введите количество дроблений: ");
            n = Convert.ToDouble(Console.ReadLine());
            h = (a + b) / n;
            for (double x = a; x <= b; x += h)
            {
                answ += SRect(h, F(x));
            }
            Console.WriteLine("Результат, полученный методом прямоугольников: " + Convert.ToString(answ));
        }
    }
}
