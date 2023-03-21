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
            h = Math.Abs(a - b) / n;
            for (int x = 0; x < n; x ++)
            {
                answ += SRect(h, F(x*h + a));
            }
            Console.WriteLine("Результат, полученный методом прямоугольников: " + Convert.ToString(answ));
        }
    }
}
