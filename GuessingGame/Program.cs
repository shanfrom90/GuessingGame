using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winningNumber = random.Next(1,11);
            int attempts = 0;
            int attemptLimit = 3;
            bool outOfAttempts = false;
           
          
            while (!outOfAttempts && attempts < attemptLimit)
            {
                Console.WriteLine("Please enter a number between 1 and 10. I will tell you when you've guessed the winning number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber == -1)
                {
                    outOfAttempts = true;
                }
                else if (userNumber == winningNumber)
                {
                    Console.WriteLine("You won!");
                    outOfAttempts = true;
                }
                else if (userNumber == 0)
                {
                    Console.WriteLine("Please enter a number between one and ten");
                }

                else if (userNumber > winningNumber)
                {
                    Console.WriteLine("The winning number is smaller.");

                }

                else if (userNumber < winningNumber)
                {
                    Console.WriteLine("The winning number is larger.");

                }
          
                else
                {
                    Console.WriteLine("Sorry, you lose");
                   
                    
                }

                attempts++;
            }
        }
    }
}
