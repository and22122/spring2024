using System;

class Program
{
    static void Main(string[] args)
    {
        Random randGen = new Random();
        bool keepGoing = false;

        do {
            int n = randGen.Next(1, 101);

            int guess;
            int guesses = 0;

            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > n) {
                    Console.WriteLine("Too high");
                }
                else if (guess == n) {
                    Console.WriteLine("You guessed the magic number!");
                }
                else {
                    Console.WriteLine("Too low");
                }

                guesses ++;
            } while (guess != n);

            Console.WriteLine($"It took you {guesses} tries to guess the magic number!");

            Console.WriteLine("\nDo you want to play again? Type \"yes\" to continue");
            keepGoing = Console.ReadLine().ToLower() == "yes";
        } while (keepGoing);
    }
}