using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.Write("Moi ban nhap ten cua minh: " );
            string name = Console.ReadLine();
            Console.WriteLine("Ten cua ban la: {0}", name);
            Console.Write("Moi ban nhap ngay sinh: ");
            string date = Console.ReadLine();
            Console.WriteLine("Ngay sinh cua ban la: {0}", date);
            Console.Write("Moi Ban Nhap que quan: ");
            string address = Console.ReadLine();
            Console.WriteLine("Your address is: {0}", address);
            Console.ReadKey();
           
        }
    }
}
