using System;

namespace CharDemo
{
    class Program
    {
        static void CharManipulation()
        {
            string s = "";
            Console.WriteLine("Enter a string:  ");
            s = Console.ReadLine();
            int countUperChar = 0, countLowercase = 0, countNum = 0, countChar = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i]))
                    

                    countLowercase++;


                if (char.IsUpper(arr[i]))
                    countUperChar++;
                if (char.IsDigit(arr[i]))
                    countNum++;
                if (char.IsWhiteSpace(arr[i]))
                    countChar++;
                }
            Console.WriteLine("the string have {0} lower case charactor!",countLowercase);
            Console.WriteLine("the string has {0} upper case charactor! ", countUperChar);
            Console.WriteLine("the string has {0}  number! ", countNum);
            Console.WriteLine("the string has {0}  white spaces! ", countChar);
        }

        static void CharManipulation2()
        {
            string s = "";
            Console.WriteLine("Enter a string:  ");
            s = Console.ReadLine();
            int countUperChar = 0, countLowercase = 0, countNum = 0, countChar = 0;
            //char[] arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char charactor = s[i];
                if (char.IsLower(charactor))


                    countLowercase++;


                if (char.IsUpper(charactor))
                    countUperChar++;
                if (char.IsDigit(charactor))
                    countNum++;
                if (char.IsWhiteSpace(charactor))
                    countChar++;
            }
            Console.WriteLine("the string have {0} lower case charactor!", countLowercase);
            Console.WriteLine("the string has {0} upper case charactor! ", countUperChar);
            Console.WriteLine("the string has {0}  number! ", countNum);
            Console.WriteLine("the string has {0}  white spaces! ", countChar);
        }
        static void StringDemantion3()
        {
            string s;
            Console.WriteLine("Input a string: ");
            s = Console.ReadLine();
            Console.WriteLine("please input next string: ");
            string s2 = Console.ReadLine();
            int kq = s.CompareTo(s2);
            //not case sensitive
            // int kq = s.ToLower().CompareTo(s2.ToLower());
            if (kq == 0)
            {
                Console.WriteLine("s and s2 is similar!");

            }else if (kq < 0)
            {
                Console.WriteLine("s<s2");

            }
            else
            {
                Console.WriteLine("s > s2");
            }
        }
        static void Stringdemantion4() { 
            string s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);

        }
        static void Main(string[] args)
        {
            Stringdemantion4();        }
    }
}
