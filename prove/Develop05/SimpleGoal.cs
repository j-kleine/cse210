using System;

public class SimpleGoal : Goal
{
    private string _goalType = "Simple Goal:";
    private bool _status;

    public SimpleGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _status = false;
    }

    public SimpleGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points)
    {
        _status = status;
    }

    public Boolean GoalFinished()
    {
        return _status;
    }

    public override void ListGoal(int i)
    {
        if (GoalFinished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }

        else if (GoalFinished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }

    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}"); 
    }

    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}"); 
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        _status = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}