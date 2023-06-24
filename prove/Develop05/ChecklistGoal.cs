using System;

public class ChecklistGoal : Goal
{
    private string _goalType = "Checklist Goal:";
    private bool _status;
    private int _numberTimes;
    private int _bonusPoints;
    private int _count;
    private bool _bonusPointsAdded;

    public ChecklistGoal(string goalType, string name, string description, int points, int bonusPoints, int numberTimes, int count) : base(goalType, name, description, points, bonusPoints)
    {
        _status = false;
        _bonusPointsAdded = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }

    public ChecklistGoal(string goalType, string name, string description, int points, int bonusPoints, bool status, int numberTimes, int count) : base(goalType, name, description, points, bonusPoints)
    {
        _status = status;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public int GetNumberTimes()
    {
        return _numberTimes;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount()
    {
        _count = _count + 1;
    }

    public bool GoalFinished()
    {
        return _status;
    }

    public bool GetBonusPointsAdded()
    {
        return _bonusPointsAdded;
    }

    public void SetBonusPointsAdded(bool value)
    {
        _bonusPointsAdded = value;
    }

    public override void ListGoal(int i)
    {
        if (!GoalFinished())
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()}) -- Currently Completed: {GetCount()}/{GetNumberTimes()}");
        }

        else if (GoalFinished())
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()}) -- Currently Completed: {GetCount()}/{GetNumberTimes()}");
        }
    }

    public override string SaveGoal()
    {
         return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetBonusPoints()}; {_status}; {GetNumberTimes()}; {GetCount()}");
    }

    public override string LoadGoal()
    {
         return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetBonusPoints()}; {_status}; {GetNumberTimes()}; {GetCount()}");
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetCount();
        int points = GetPoints();
        int bonusPoints = GetBonusPoints();

        if (_count == _numberTimes)
        {
            _status = true;
            points = points + bonusPoints;
            Console.Clear();
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }

        else
        {
            Console.Clear();
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
    }
}