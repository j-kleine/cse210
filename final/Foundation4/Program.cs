using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Running running = new Running("date", duration in min, distance in km)
        Running running = new Running("03 Nov 2022", 30, 6.0);
        activities.Add(running);

        // Cycling cycling = new Cycling("date", duration in min, speed in km/h)
        Cycling cycling = new Cycling("03 Nov 2022", 60, 15.0);
        activities.Add(cycling);

        // Swimming swimming = new Swimming("date", duration in min, number of laps)
        Swimming swimming = new Swimming("03 Nov 2022", 20, 20);
        activities.Add(swimming);

        Console.Clear();

        foreach (Activity activity in activities)
        {
            //Console.WriteLine("=========================================================================");
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
            //Console.WriteLine("=========================================================================\n");
        }
    }
}
