using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winningNumber = random.Next(1, 11);
            Console.WriteLine("Please enter a number between 1 and 10. I will tell you when you've guessed the winning number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int attempts = 0;
            int attemptLimit = 1;
            bool outOfAttempts = false;
            if (userNumber == 0)
            {
                Console.WriteLine("Please check your number to make sure it is between 1 and 10");
            }

            else if (userNumber == winningNumber)
            {
                Console.WriteLine("You won!");
            }
            else if (userNumber == -1)
            {
                Console.Clear();
            }
            while (userNumber != winningNumber && !outOfAttempts)
            {
                
                if (attempts<attemptLimit)
                {
                  
                    Console.WriteLine("Try again!");
                    userNumber = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                    ;
                }
                else
                {
                    outOfAttempts = true;
                    Console.WriteLine("Sorry, you lose");
                }
              
            }
           

        }
    }
}
