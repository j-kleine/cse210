using System;

public class PromptGenerator
{
    public string[] _prompts = {
        "What are three things that you're grateful for today?",
        "Describe a recent challenge you faced and how you overcame it.",
        "Write about a moment that made you feel proud of yourself.",
        "What's something that you've been procrastinating on, and what steps can you take to start working on it?",
        "Write about a recent accomplishment that you're proud of."
    };
    
    public Random _random;

    public PromptGenerator()
    {
        _random = new Random();
    }

    public string GeneratePrompt()
    {
        int randomNumber = _random.Next(0, _prompts.Length);
        return _prompts[randomNumber];
    }
}