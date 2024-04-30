using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() {
            Console.WriteLine("What is your username?");

            return Console.ReadLine();
        }

        static int PromptUserNumber() {
            Console.WriteLine("What is your favorite number?");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int n) {
            return n * n;
        }

        static void DisplayResult() {
            string name = PromptUserName();
            int num = SquareNumber(PromptUserNumber());

            Console.WriteLine($"Your user name is {name} and the square of your favorite number is {num}.");
        }

        DisplayWelcome();

        DisplayResult();
    }
}