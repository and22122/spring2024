using System;

class Program
{
    static void Main(string[] args)
    {
        Random randGen = new Random();
        bool badNum = false;

        for (int i = 0; i < 1000; i ++) {
            int n = randGen.Next(1, 11);

            if (n == 11) {
                badNum = true;
            }
        }

        Console.Write(badNum);
    }
}