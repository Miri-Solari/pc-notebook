using System;

namespace LAB_2
{
    class Program
    {
        static double F(double x)
        {
            return x * x * x - 2 - Math.Log(x + 2);
        }



        static double Fi(double x)
        {
            return 3*x*x - 1/(x+2);
        }

        static double F2(double a, double b)
        {
            return a - (b-a)/(F(b)-F(a))*F(a);
        }

        static void Main(string[] args)
        {
            double a, b, x0, E;
            int S = 0;

            Console.WriteLine("Введите начало отрезка(> -2): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конец отрезка: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (F(a)*F(b) > 0)
            {
                Console.WriteLine("Ошибка, некорректные значения");
                Environment.Exit(1);
            }
            x0 = (a + b) / 2;
            Console.WriteLine("Введите погрешность: ");
            E = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Метод Нтютона\n");
            double cur = x0;
            double next = cur - F(cur)/Fi(cur);
            double t;
            S = 1;
            while (Math.Abs(next - cur) > E)
            {
                S += 1;
                cur = next;
                next = cur - F(cur) / Fi(cur);
            }

            Console.WriteLine("x = " + Convert.ToString(next));
            Console.WriteLine("Кол-во итераций = " + Convert.ToString(S));


            Console.WriteLine("\nМетод Хорд\n");
            x0 = F2(a,b);
            S = 0;
            double prev = 0;
            while (Math.Abs(x0 - prev) > E)
            {
                if (F(x0) * F(b) < 0)
                {
                    a = x0;
                }
                else
                {
                    b = x0;
                }
                prev = x0;
                x0 = F2(a,b);
                S += 1;
            }
            Console.WriteLine("x = " + Convert.ToString(x0));
            Console.WriteLine("Кол-во итераций = " + Convert.ToString(S));

        }
    }
}
