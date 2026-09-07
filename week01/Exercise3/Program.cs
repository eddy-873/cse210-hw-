using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is your magic number?.");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is you guess number?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");

            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }

    }
}