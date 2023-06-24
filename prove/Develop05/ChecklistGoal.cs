using System;

public class ChecklistGoal : Goal
{
    private string _goalType = "Checklist Goal:";
    private bool _status;
    private int _numberTimes;
    private int _bonusPoints;
    private int _count;

    public ChecklistGoal(string goalType, string name, string description, int points, int numberTimes, int bonusPoints, int count) : base(goalType, name, description, points)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }

    public ChecklistGoal(string goalType, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(goalType, name, description, points)
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

    public void SetNumberTimes()
    {
        _count = _count + 1;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount()
    {

    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public bool GoalFinished()
    {
        return _status;
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
         return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetNumberTimes()}; {GetBonusPoints()}; {GetCount()}");
    }

    public override string LoadGoal()
    {
         return ($"{_goalType}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetNumberTimes()}; {GetBonusPoints()}; {GetCount()}");
    }

    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetNumberTimes();
        int points = GetPoints();

        if (_count == _numberTimes)
        {
            _status = true;
            points = points + _bonusPoints;

            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }

        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }
}