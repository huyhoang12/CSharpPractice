using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please input your bridth day: ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("Your birth day is:  " + birthday.ToString("dd/MM/yyy"));
                Console.ReadLine();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("haha");
            }
            

        }
    }
}
