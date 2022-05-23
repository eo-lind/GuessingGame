using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess the secret number! ");
            int secretNumber = new Random().Next(1, 101);

            for (int i = 0; i < 4; i++)
            {
                // Console.WriteLine($"correct answer: {secretNumber}");
                int guess = Int32.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine($"You guessed the correct number!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry, wrong number. This was guess #{i + 1} of 4.");
                }

            }

        }
    }

}



