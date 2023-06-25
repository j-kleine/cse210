using System;

public class Level
{
    private int _levelThreshold;  // Threshold for level-up
    private int _currentLevel;  // Current level

    public Level()
    {
        _levelThreshold = 1100;  // Initial threshold for level 1
        _currentLevel = 1;  // Start at level 1
    }

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public void UpdateLevel(int totalPoints)
    {
        if (totalPoints >= _levelThreshold)
        {
            _currentLevel += 1;
            _levelThreshold = _currentLevel * 1100;
        }
    }

    public void DisplayLevel(int totalPoints)
    {
        UpdateLevel(totalPoints);
        Console.WriteLine($"You have {totalPoints} points and are Level {_currentLevel}");
    }
}
