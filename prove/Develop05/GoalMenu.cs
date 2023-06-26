using System;

public class GoalMenu
{
    private string _menu = 
    $@"The types of Goals are:
  1. Simple Goal
  2. Eternal Goal
  3. Checklist Goal
  4. Back to Main Menu
Which type of goal would you like to create? ";

    public string _goalInput;
    private int _goalChoice = 0;

    public int UserChoice()
    {
        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        
        _goalChoice = Int32.Parse(_goalInput);

        return _goalChoice;
    }
}