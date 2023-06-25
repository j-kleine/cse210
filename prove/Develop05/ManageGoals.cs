using System;
using System.Collections.Generic;
using System.IO;

public class ManageGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private Level _level;

    public ManageGoals()
    {
        _totalPoints = 0;
        _level = new Level();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
        _level.UpdateLevel(_totalPoints);
    }

    public void AddBonusPoints(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoals()
    {
        int totalPoints = GetTotalPoints();
        // _level.DisplayLevel(totalPoints);

        if (_goals.Count > 0)
        {
            _level.DisplayLevel(totalPoints);
            //Console.WriteLine($"\nYou have {totalPoints} points!");
            Console.WriteLine("\nThe Goals are:");
            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
            Console.WriteLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nYou currently have no goals saved!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish?  ");
        int select = int.Parse(Console.ReadLine())-1;
        int goalPoints = GetGoalsList()[select].GetPoints();
        int bonusPoints = GetGoalsList()[select].GetBonusPoints();

        if (GetGoalsList()[select] is ChecklistGoal checklistGoal && (checklistGoal.GetCount() + 1) == checklistGoal.GetNumberTimes())
        {
            AddBonusPoints(bonusPoints);
            checklistGoal.SetBonusPointsAdded(true);
        }
        
        AddPoints(goalPoints);
        
        GetGoalsList()[select].RecordGoalEvent(_goals);

        ListGoals();
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetTotalPoints());
            // Save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
        Console.Write($"File saved as <{userFileName}>");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            // skip the first line of text file to read the goals
            readText = readText.Skip(1).ToArray();

            // loop though text file for goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                int bonusPoints = int.Parse(entries[4]);
                bool status = Convert.ToBoolean(entries[5]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, 0, status);
                    AddGoal(simpleGoal);
                }

                else if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eternalGoal = new EternalGoal(type, name, description, points, 0, status);
                    AddGoal(eternalGoal);
                }
                
                else if (entries[0] == "Checklist Goal:")
                {
                    int numberTimes = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, bonusPoints, status, numberTimes, counter);
                    AddGoal(checklistGoal);
                }
            }
            ListGoals();
        }
        else
        {
            Console.WriteLine($"!!! The file <{userFileName}> does not exist. !!!\n");
        }
    }
}