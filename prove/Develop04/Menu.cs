using System;

public class Menu
{
    private string _menu = 
    $@"Menu Options:
  1. Start breathing activity
  2. Start reflecting activity
  3. Start listing activity
  4. Quit
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