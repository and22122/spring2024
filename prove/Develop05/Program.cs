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
    static void save (String filename, List<Goal> Goals)
    {
        using (StreamWriter outFile = new StreamWriter(filename))
        {
            foreach (Goal g in Goals) {
                outFile.WriteLine(g.toStringType());
            }
        }
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

                    save(filename, goals);

                    break;
                case "L":
                    Console.WriteLine("What file do you want to open?");
                    String targetFile = Console.ReadLine();
                    
                    string[] sourceText = System.IO.File.ReadAllLines(targetFile);

                    goals = new List<Goal>();

                    for (int i = 0; i < sourceText.Count(); i ++)
                    {
                        string[] line = sourceText[i].Split(" ");

                        switch (line[0])
                        {
                            case "Simple":
                                goals.Add(new SimpleGoal(int.Parse(line[0]), line[1], int.Parse(line[2])));
                                break;
                            case "Eternal":
                                goals.Add(new EternalGoal(int.Parse(line[0]), line[1], int.Parse(line[2])));
                                break;
                            case "Checklist":
                                goals.Add(new ChecklistGoal(int.Parse(line[0]), line[1], int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4])));
                                break;
                            default:
                                Console.WriteLine("Invalid value. Please abort.");
                                break;
                        }
                    }
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