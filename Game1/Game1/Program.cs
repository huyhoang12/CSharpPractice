using System;


/*
    computer will create a random number, player has to guess what is that number.
    player has 7 chances to guess what is the number which computer create. 
    after game finnish (win or lose because wrong answer 7 times.) ask player want to try again or not.
     */
namespace Game1
{
    class Program
    {
        static void Play()
        {
            Random rd = new Random();
            int playerInput;
            int computerRandomNum = rd.Next(501);
            int timePlay = 0;
            Console.WriteLine("Bot give a number in range 0 to 500, guess what is that number?");
            while (true)
            {
              
              
                timePlay++;
                Console.WriteLine("This is your {0} time! Good Luck!", timePlay);
                playerInput = int.Parse(Console.ReadLine());
                // guess the true number
                if (playerInput== computerRandomNum)
                {
                    Console.WriteLine("Congratiation!!! BOt number is: {0}", computerRandomNum);
                    break;
                }if(playerInput< computerRandomNum)
                {
                    Console.WriteLine("Your number is smaller Bot number!!!");
                }
                else
                {
                    Console.WriteLine("Your number is greater than Bot Number!!!"); 
                }
                if (timePlay == 7)
                {
                    Console.WriteLine("GAME OVER!!!! You give wrong answer 7 times!");
                    Console.WriteLine("Bot Number is {0}", computerRandomNum);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Play();
                Console.WriteLine("Do you want try again? (y/n)");
                string s = Console.ReadLine();
                if (s == "n")
                {
                    break;
                }
                if(s=="y")
                {
                    Play();
                }
                else
                {
                    Console.WriteLine("need to be y or n");
                    break;
                }
            }
            
        }
    }
}
