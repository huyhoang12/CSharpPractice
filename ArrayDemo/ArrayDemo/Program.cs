using System;

namespace ArrayDemo
{
    class Program
    {
        /*
            SUMMARY 
            create 1 array M has n element, then:
            1- input random value for M
            2- export M's elements
            3- Reverse M
            4- sort M
            5- calculate sum of M's element
            6- search element 
            7- linear search
            */
        static void Array1D()
        {
            Console.WriteLine("please imput the number element of array!");
            int n = int.Parse(Console.ReadLine());
            int[] M = new int[n];
            Random rd = new Random();
            //1- input random value M's elements
            for(int i =0; i<M.Length; i++)
            {
                M[i] = rd.Next(100);
            }
            //2- export M's element

            for(int i=0; i<M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }

            //3- reverse M
            Array.Reverse(M);
            Console.WriteLine();
            Console.WriteLine(" M after reverse!");
            foreach(int i in M)
            {
                Console.Write(i + " ");
            }
            //4- sort M
            Array.Sort(M);
            Console.WriteLine();
            Console.WriteLine(" M after sort!");
            foreach (int i in M)
            {
                Console.Write(i + " ");
            }
            //5- sum of M's elements

            int sum = 0;
            foreach(int i in M)
            {
                sum += i;
            }
            Console.WriteLine("sum of M's elements: {0}", sum);

            //6- search element in M
            Console.WriteLine("which element you want to search?");
            int k = Convert.ToInt32(Console.ReadLine());
            int kq = Array.BinarySearch(M, k);
            if(kq==-1)
            {
                Console.WriteLine("cannot find {0} in M", k);

            }
            else
            {
                Console.WriteLine("found {0} at position {1}", k, kq);
            }

            //7- linear search
            Console.WriteLine("whichis the other element you want to search?");
           k = Convert.ToInt32(Console.ReadLine());
            kq = -1;
            for (int i=0; i<M.Length; i++)
            {
                if (M[i] == k)
                {
                    kq = i;
                    break;
                }
            }
            if (kq == -1)
            {
                Console.WriteLine("cannot find {0} in M", k);

            }
            else
            {
                Console.WriteLine("found {0} at position {1}", k, kq);
            }

        }
        //2D Array
        static void Array2D()
        {
            Console.WriteLine("input the number of row: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("input the number of Col: ");
            int col = int.Parse(Console.ReadLine());
            int[,] M = new int[row, col];
            Random rd = new Random();
            for( int i=0; i<row-1; i++)
            {
                for(int j=0; j<col-(1); i++)
                {
                    M[i, j] = rd.Next(100);
                }
            }
            Console.WriteLine("Array 2D contain: ");
            for(int i=0; i<M.GetLength(0); i++)
            {
                for(int j= 0; j<M.GetLength(1); j++)
                {
                    Console.WriteLine(M[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Array1D();
            Array2D();

        }
    }
}
