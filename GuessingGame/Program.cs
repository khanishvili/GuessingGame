using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease gues a Number between 1 to 10 or 0 for Help");
            // Random range = new Random();
            // bool runprogram = true;
            string  guessNumber;
            int incriment=0;
            do
            {

                guessNumber = Console.ReadLine();
                if (guessNumber.Equals("7"))
                {
                    Console.WriteLine("You Won The game");
                }
                else if (guessNumber.Equals("0"))
                {
                    Console.WriteLine("=========Instructions=========");
                    Console.WriteLine("Gueas a Number between 1 to 10");
                    Console.WriteLine("hit enter to submit your guess");
                }
                else if (guessNumber.Equals("-1"))
                {
                    incriment = 1;
                }
                else
                {
                    int temp = Convert.ToInt32(guessNumber);
                    if (temp < 7)
                    {
                        Console.WriteLine("Wining number is larger than Guessed NUmber!!");

                    }
                     else if (temp > 7)
                    {
                        Console.WriteLine("Wining number is less than Guessed NUmber!!");

                    }
                   
                }
                incriment++;
               

            }
            while (incriment < 2);
            Console.WriteLine("Game Over");
        }
    }
}
