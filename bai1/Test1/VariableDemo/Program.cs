using System;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte bienByte = 3;
            short bienShort = 9;
            int bienInt = 10;
            long bienLong = 0;
            bienLong = bienByte;
            Console.WriteLine("Bien Long= " + bienLong);
            bienLong = bienInt;
            Console.WriteLine("BienLong= {0}", bienLong);
            bienShort = bienByte;
            Console.WriteLine("BienShort= {0}", bienShort);
            bienInt = bienShort;
            Console.WriteLine("BienInt= {0}", bienInt);
            Console.ReadKey();
        }
    }
}
