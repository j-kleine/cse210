using System;

public abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;

    public Goal(string goalType, string name, string description, int points)
    {
        _goalType = goalType;
        _name = name;
        _description = description;
        _points = points;
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

    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}