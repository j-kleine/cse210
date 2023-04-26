using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magNumber = randomGenerator.Next(1, 99);

        // Console.Write("What is the magic number? ");
        // int magNumber = int.Parse(Console.ReadLine());

        int guess = -1;
        int guessNumber = 0;

        while (guess != magNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessNumber = guessNumber + 1;

            if (magNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {guessNumber} guesses.");
            }        }

    }
}