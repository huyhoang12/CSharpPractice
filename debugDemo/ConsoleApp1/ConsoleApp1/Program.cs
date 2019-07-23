using System;

namespace ConsoleApp1
{
    class Program
    {
        static string GPTB2(double a, double b, double c)
        {
            if (a == 0)
            {
                if(b==0 && c == 0)
                {
                    return "unlimited";
                }if (b == 0 && c != 0)
                    return "NO";
                return "x= " + (-c / b);
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                {
                    return "No";

                }if (delta == 0)
                {
                    double x = -b / 2 * a;
                    return "Nghiem kep x1=x2=" +x;
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    return "x1= " + x1 + "; x2= " + x2;
                }
            }
        }
        static void Main(string[] args)
        {
            string result = GPTB2(0, 0, 0);
            Console.WriteLine(result);

             result = GPTB2(0, 0, 3);
            Console.WriteLine(result);

            result = GPTB2(0, 8, 3);
            Console.WriteLine(result);

                 result = GPTB2(2, 5, -7);
            Console.WriteLine(result);
        }
    }
}
