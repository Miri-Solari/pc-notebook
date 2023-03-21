using System;

namespace LAB_5_7_
{
    class Program
    {
        static double F(double x)
        {
            return Math.Log(x * x + 2);
        }
        static double STrap(double h, double y0, double y1)
        {
            return (y0 + y1) / 2 * h;
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 100;
            double n;
            double h, answ = 0;
            Console.WriteLine("Введите количество дроблений: ");
            n = Convert.ToDouble(Console.ReadLine());
            h = Math.Abs(a - b) / n;
            for (int x = 0; x < n; x++)
            {
                answ += STrap(h, F(x * h + a), F(x * h + a + h));
            }
            Console.WriteLine("Результат, полученный методом Трапеций: " + Convert.ToString(answ));
        }
    }
}
