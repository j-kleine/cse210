using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private string _messageIn = "Breathe in...";
    private string _messageOut = "Now breathe out...";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string name, int duration) : base(name, duration)
    {

    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        int _secondsTimer = 0;
        while (_secondsTimer < seconds)
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 4; i > 0; i--) // Breathe IN
            {
                Console.Write($"\r{_messageIn}{i}");
                Thread.Sleep(1000);
                _secondsTimer += 1;
            }
            Console.Write($"\r{_messageIn} ");
            Console.WriteLine();

            for (int i = 5; i > 0; i--) // Breathe OUT
            {
                Console.Write($"\r{_messageOut}{i}");
                Thread.Sleep(1000);
                _secondsTimer += 1;
            }
            Console.Write($"\r{_messageOut} ");
        }
    }
}