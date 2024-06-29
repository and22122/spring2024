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
    static void save (String filename, List<Goal> goalList)
    {
        using (StreamWriter outFile = new StreamWriter(filename))
        {
            foreach (Goal g in goalList) {
                outFile.WriteLine(g.toStringType());
            }
        }
    }
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        String option = "";

        do
        {
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
                case "c":
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
                            goals.Add(new ChecklistGoal(GetInt("How many points is the goal worth?"), GetInput("What should the task be?"), GetInt("How many times does the goal need to be completed?"), GetInt("How many points is the end bonus worth?")));
                            break;
                        default:
                            Console.WriteLine("Invalid input.");
                            break;
                    }

                    break;
                case "u":
                    Console.WriteLine($"Which goal do you want to update? (Please type a whole number from 1 to {goals.Count})");
                    int goalNum = int.Parse(Console.ReadLine());
                    goals[goalNum - 1].update();
                    break;
                case "d":
                    for (int i = 0; i < goals.Count(); i ++)
                    {
                        goals[i].display();
                    }
                    break;
                case "s":
                    Console.WriteLine("What file do you want to open?");
                    String filename = Console.ReadLine();

                    save(filename, goals);

                    break;
                case "l":
                    Console.WriteLine("What file do you want to open?");
                    String targetFile = Console.ReadLine();
                    
                    string[] sourceText = System.IO.File.ReadAllLines(targetFile);

                    goals = new List<Goal>();

                    for (int i = 0; i < sourceText.Count(); i ++)
                    {
                        string[] line = sourceText[i].Split("\\");

                        switch (line[0])
                        {
                            case "Simple":
                                goals.Add(new SimpleGoal(int.Parse(line[1]), line[2], int.Parse(line[3])));
                                break;
                            case "Eternal":
                                goals.Add(new EternalGoal(int.Parse(line[1]), line[2], int.Parse(line[3])));
                                break;
                            case "Checklist":
                                goals.Add(new ChecklistGoal(int.Parse(line[1]), line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5])));
                                break;
                            default:
                                Console.WriteLine("Invalid value. Please abort.");
                                break;
                        }
                    }
                    break;
                case "q":
                    Console.WriteLine("Ending program.");
                    break;
                default:
                    Console.WriteLine("Unexpected input");
                    break;
            }

        } while(option != "q");
    }
}