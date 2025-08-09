using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        int option = 0;
        while (option != 6)
        {
            Console.WriteLine($"\nYou have {totalPoints} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
                CreateGoal();
            else if (option == 2)
                ShowGoals();
            else if (option == 3)
                SaveGoals();
            else if (option == 4)
                LoadGoals();
            else if (option == 5)
                RecordGoal();
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
            goals.Add(new SimpleGoal(name, description, points));
        else if (type == 2)
            goals.Add(new EternalGoal(name, description, points));
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int times = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, times, bonus));
        }
    }

    static void ShowGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetails()}");
        }
    }

    static void RecordGoal()
    {
        ShowGoals();

        Console.Write("Which goal did you accomplish? ");
        int number = int.Parse(Console.ReadLine());

        int pointsEarned = goals[number - 1].RecordEvent();
        totalPoints += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {totalPoints} points");
    }

    static void SaveGoals()
    {
        Console.Write("What is the filename for the goal? ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                file.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        totalPoints = int.Parse(lines[0]);
        goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "Simple")
            {
                var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) g.RecordEvent();
                goals.Add(g);
            }
            else if (type == "Eternal")
            {
                goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "Checklist")
            {
                var g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                int done = int.Parse(parts[6]);
                for (int j = 0; j < done; j++) g.RecordEvent();
                goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded!");
    }
}
