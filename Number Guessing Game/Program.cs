using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)

        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);
            int Guess = 0;

            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

            while (Guess != 55)
            {
                Guess = Convert.ToInt32(Console.Read());

                while (Guess < 50)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + 7 + " .  Can you guess what it is?");
                    Console.ReadLine();

                }
                while (Guess > 100)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + 56 + " .  Can you guess what it is");
                    Console.ReadLine();
                }
            }
            while (Guess == 55)
            {
                Console.WriteLine("Well done! The answer was " + 55);
                Console.ReadLine();
            }
        }
    }
}

