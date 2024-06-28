using System;

class Program
{
    static String GetInput(String prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }
    static int GetInt(String prompt)
    {
        Console.WriteLine(prompt);
        return int.Parse(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        String option = "";

        do
        {
            List<Goal> goals = new List<Goal>();
            Console.WriteLine("What do you want to do? (please type a letter)");
            Console.WriteLine("- [C]reate a new goal");
            Console.WriteLine("- [U]pdate a goal");
            Console.WriteLine("- [D]isplay goals");
            Console.WriteLine("- [S]ave goals");
            Console.WriteLine("- [L]oad goals");
            Console.WriteLine("- [Q]uit");

            option = Console.ReadLine().ToLower();

            switch (option)
            {
                case "C":
                    Console.WriteLine("Which type of goal do you want to make? Please type \"Simple\", \"Eternal\", or \"Checklist.\"");
                    String goalType = Console.ReadLine().ToLower();

                    switch (goalType)
                    {
                        case "simple":
                            goals.Add(new SimpleGoal(GetInt("How many points is the goal worth?"), GetInput("What should the task be?")));
                            break;
                        case "eternal":
                            goals.Add(new EternalGoal(GetInt("How many points is the goal worth?"), GetInput("What should the task be?")));
                            break;
                        case "checklist":
                            goals.Add(new ChecklistGoal(GetInt("How many points is the goal worth"), GetInput("What should the task be?"), GetInt("How many times does the goal need to be completed?"), GetInt("How many points is the end bonus worth?")));
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }

                    break;
                case "U":
                    Console.WriteLine($"Which goal do you want to update? (Please type a whole number from 1 to {goals.Count})");
                    int goalNum = int.Parse(Console.ReadLine());
                    goals[goalNum].update();
                    break;
                case "D":
                    foreach (Goal g in goals)
                    {
                        g.display();
                    }
                    break;
                case "S":
                    Console.WriteLine("What file do you want to open?");
                    String filename = Console.ReadLine();

                    break;
                case "L":
                    Console.WriteLine("What file do you want to open?");
                    String filename = Console.ReadLine();


                    break;
                case "Q":
                    Console.WriteLine("Ending program.");
                    break;
                default:
                    Console.WriteLine("Unexpected input");
                    break;
            }

        } while(option != "q");
    }
}