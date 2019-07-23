using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace VariableDemo
{

    class Solution
    {
        static int CalculateFrac(int n)
        {
            int gt = 1;
            for(int i=1; i<=n; i++)
            {
                gt *= i;
            }
            return gt;
        } 
        static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }
        static string gpt(double a, double b)
        {
            if (a == 0 && b == 0)
                return "vo so nghiem";
            if (a == 0 && b != 0)
                return "khong Nghem";
            return "x=" + -b / a;
        }
        static void fn1(int a)
        {
            a = a + 5;
            Console.WriteLine("a in the fn1 method= {0}", a);
        }
        static void fn2(ref int b)
        {
            b = b + 2;
            Console.WriteLine("b in fn2={0}", b);

        }
        static void fn3(out double c)
        {
            c = 9;
            c = c - 5;
            Console.WriteLine("C in fn3= {0}", c);
        }
        static void Main(string[] args)
        {
            //out need to be Initialization inside the method.
            double c;
            fn3(out c);
            Console.WriteLine("c after call fn3= {0}", c);
            // ref need to be Initialization first
            int b = 10;
            fn2(ref b);
            Console.WriteLine(" b after call fn2= {0}", b);

            /*int a = 5;
            fn1(a);
            Console.WriteLine(a);
           /* int a = 19;
            int c = 9;
          Console.WriteLine( Min(a, c));
            /*
            int n;
            Console.WriteLine("Input the number: ");

            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}!= {1}", n, CalculateFrac(n));

            Console.WriteLine(gpt(0, 8));*/
        }
            

        }
    }

