using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);


        int countGuesses = 0;

        int guessNumber = 0;


        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (number > guessNumber)
            {
                Console.WriteLine("Higher");
                countGuesses += 1;
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
                countGuesses += 1;
            }
        } while (number != guessNumber);

        Console.WriteLine($"You guessed it!, it took you {countGuesses} tries");

    }
}