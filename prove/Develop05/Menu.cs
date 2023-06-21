using System;

public class Menu
{
    private string _menu = 
    $@"Menu Options:
  1. Create New Goal
  2. List Goals
  3. Save Goals
  4. Load Goals
  5. Record Event
  6. Quit
Select a choice from the menu: ";

    public string _userInput;
    private int _userChoice = 0;

    public int UserChoice()
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        
        _userChoice = Int32.Parse(_userInput);

        return _userChoice;
    }
}