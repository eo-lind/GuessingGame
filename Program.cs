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
            int secretNumber = 42;
            int guess = Int32.Parse(Console.ReadLine());
            if (guess == secretNumber){
                Console.WriteLine("You guessed the correct number!");
            } else {
                 Console.WriteLine("Sorry, wrong number.");
            }
           
        }
    }
    
}