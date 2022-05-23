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
            int guess = Int32.Parse(Console.ReadLine());
            Console.WriteLine(guess);
        }
    }
    
}