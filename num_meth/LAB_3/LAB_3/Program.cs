using System;

namespace LAB_2
{
    class Program
    {
        static double Fx(double x)
        {
            return (1 + Math.Sin(1 - Math.Cos(x))) / 2 - x;
        }

        static double Fxi(double x)
        {
            return Math.Sin(x) * Math.Cos(Math.Cos(x) - 1) / 2 - 1;
        }

        static double Fxfi(double x)
        {
            return (1 + Math.Sin(1 - Math.Cos(x))) / 2;
        }

        static double Fy(double y)
        {
            return y + Math.Cos((1 + Math.Sin(y - 0.5d)) / 2) - 1.5d;
        }

        static double Fyi(double y)
        {
            return 1 - Math.Sin((Math.Sin(y - 0.5d) + 1) / 2) * Math.Cos(y - 0.5d) / 2;
        }

        static double Fyfi(double y)
        {
            return -1 * (Math.Cos((1 + Math.Sin(y - 0.5d)) / 2) - 1.5d);
        }

        static void Main(string[] args)
        {
            double a, b, x0, E;
            int S = 0;

            a = -10;
            b = 20;
            x0 = (a + b) / 2;
            Console.WriteLine("Введите погрешность: ");
            E = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Метод Нтютона\n");
            double curx = x0;
            double nextx = curx - Fx(curx) / Fxi(curx);
            S = 1;
            while (Math.Abs(nextx - curx) > E)
            {
                curx = nextx;
                nextx = curx - Fx(curx) / Fxi(curx);
            }
            double cury = x0;
            double nexty = curx - Fy(cury) / Fyi(cury);

            while (Math.Abs(nexty - cury) > E)
            {
                cury = nexty;
                nexty = cury - Fy(cury) / Fyi(cury);
            }

            Console.WriteLine("x = " + Convert.ToString(nextx));
            Console.WriteLine("y = " + Convert.ToString(nexty));


            Console.WriteLine("\nМетод Простых итераций\n");
            curx = x0;
            nextx = Fxfi(curx);
            S = 1;
            while (Math.Abs(nextx - curx) > E)
            {
                curx = nextx;
                nextx = Fxfi(curx);
            }
            cury = x0;
            nexty = Fyfi(cury);

            while (Math.Abs(nexty - cury) > E)
            {
                cury = nexty;
                nexty = Fyfi(cury);
            }

            Console.WriteLine("x = " + Convert.ToString(nextx));
            Console.WriteLine("y = " + Convert.ToString(nexty));

        }
    }
}
