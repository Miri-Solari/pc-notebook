using System;

namespace lab_1
{
    class Program
    {
        static double F(double x)
        {
            return x * x * x - 2 - Math.Log(x + 2);
        }



        static double Fi(double x)
        {
            return Math.Cbrt(2 + Math.Log(x+2));
        }
        
        static void Main(string[] args)
        {
            double a, b, x0, E;
            int S = 0;
            
            Console.WriteLine("Введите начало отрезка(> -2): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка: ");
            b = Convert.ToDouble(Console.ReadLine());
            x0 = (a + b) / 2;
            double a1 = a;
            double b1 = b;
            Console.WriteLine("Введите погрешность: ");
            E = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Метод дихотомии\n");
            while (Math.Abs(a - b) > E)
            {
                double fx = F(x0);
                double fa = F(a);
                double fb = F(b);
                if (fx > 0 && fa < 0 || fx < 0 && fa > 0)
                {
                    b = x0;
                }
                else if (fx < 0 && fb > 0 || fx > 0 && fb < 0)
                {
                    a = x0;
                }
                x0 = (a + b) / 2;
                S += 1;
            }

            Console.WriteLine("x = " + Convert.ToString(x0));
            Console.WriteLine("Кол-во итераций = " + Convert.ToString(S));


            Console.WriteLine("\nМетод Простых итераций\n");
            x0 = (a1 + b1) / 2;
            double cur = Fi(x0);
            double next = Fi(cur);
            double t;
            S = 1;
            while (Math.Abs(next - cur) > E)
            {
                S += 1;
                t = next;
                next = Fi(cur);
                cur = t;
            }
            Console.WriteLine("x = " + Convert.ToString(cur));
            Console.WriteLine("Кол-во итераций = " + Convert.ToString(S));

        }
    }
}
