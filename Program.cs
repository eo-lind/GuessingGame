using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a difficulty level: Easy, Medium, Hard, or Cheater");

            string difficulty = Console.ReadLine().ToLower();

            int numberOfGuesses = 0;
            int guess = new int();
            int secretNumber = new Random().Next(1, 101);

            if (difficulty == "easy")
            {
                numberOfGuesses = 8;
            }
            else if (difficulty == "medium")
            {
                numberOfGuesses = 6;
            }
            else if (difficulty == "hard")
            {
                numberOfGuesses = 4;
            }
            else if (difficulty == "cheater")
            {

                while (secretNumber != guess)
                {
                    {
                        Console.WriteLine("Guess the secret number! ");
                        guess = Int32.Parse(Console.ReadLine());
                    };

                    if (secretNumber < guess)
                    {
                        Console.WriteLine("Guess lower.");

                    }
                    else if (secretNumber > guess)
                    {
                        Console.WriteLine("Guess higher.");
                    }
                }


                Console.WriteLine("You got it!");
                return;
            };


            Console.WriteLine("Guess the secret number! ");


            for (int i = 1; i <= numberOfGuesses; i++)
            {
                // Console.WriteLine($"correct answer for testing purposes: {secretNumber}");

                Console.WriteLine($"You have {numberOfGuesses} guesses. You are on guess #{i}.");

                guess = Int32.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine($"You guessed the correct number!");
                    break;
                }
                else
                {
                    if (secretNumber > guess)
                    {
                        Console.WriteLine("Guess higher!");
                    }
                    else
                    {
                        Console.WriteLine("Guess lower.");
                    }

                };

            };

        }
    }

}



