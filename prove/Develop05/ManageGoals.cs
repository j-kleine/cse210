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

        if (_goals.Count > 0)
        {
            Console.WriteLine("\nThe Goals are:");
            int index = 1;
            // Loop though goals list
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
            Console.WriteLine();
            _level.DisplayLevel(totalPoints);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You currently have no goals saved!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? (format .txt is automatically added) > ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points and Current Level
            outputFile.WriteLine($"{GetTotalPoints()}; {_level.GetCurrentLevel()}");
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
        Console.Write("What is the filename of the goal file? (format .txt is automatically added) > ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            // read the first line of text file for total stored points and current level
            string[] pointsAndLevel = readText[0].Split("; ");
            int totalPoints = int.Parse(pointsAndLevel[0]);
            int currentLevel = (int.Parse(pointsAndLevel[1])) - 1;
            SetTotalPoints(totalPoints);
            _level.SetCurrentLevel(currentLevel);

            // skip the first line of text file to read the goals
            readText = readText.Skip(1).ToArray();

            // loop though text file to read goals
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
}