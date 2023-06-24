using System;

public abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;
    private int _bonusPoints;

    public Goal(string goalType, string name, string description, int points, int bonusPoints)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}