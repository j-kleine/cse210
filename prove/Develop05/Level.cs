using System;

public class Level
{
    private int _levelThreshold;  // Threshold for level-up
    private int _requiredPoints; // "Next Level in {_requiredPoints}"
    private int _currentLevel;  // Current level

    public Level()
    {
        _levelThreshold = 1000;  // Initial threshold for level 1
        _requiredPoints = _levelThreshold; // Initial "Next Level in {_requiredPoints}"
        _currentLevel = 1;  // Start at level 1
    }

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public int GetRequiredPoints(int totalPoints)
    {
        _requiredPoints = _levelThreshold - totalPoints;
        return _requiredPoints;
    }

    public void UpdateLevel(int totalPoints)
    {
        if (totalPoints >= _levelThreshold)
        {
            _currentLevel += 1;
            float _levelThresholdPoints = (_currentLevel * 1000) * 1.1f;
            _levelThreshold = (int)_levelThresholdPoints;
        }
    }

    public void DisplayLevel(int totalPoints)
    {
        UpdateLevel(totalPoints);
        GetRequiredPoints(totalPoints);
        Console.WriteLine($"You have {totalPoints} points and are Level {_currentLevel} ({_requiredPoints} points to reach Level {_currentLevel + 1})");
    }
}
