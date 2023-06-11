using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu menu = new Menu();

        int seconds;
        int menuOption = 0;

        while ( menuOption != 4)
        {
            menuOption = menu.UserChoice();

            if (menuOption == 1) //Breathing Activity
            {
                Console.Clear();
                //Console.WriteLine("Welcome to the Breathing Activity.");
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", 0);
                breathingActivity.GetActivityName();
                breathingActivity.GetActivityDescription();
                seconds = breathingActivity.GetDuration();
                breathingActivity.GetReady();
                breathingActivity.Breathing(seconds);
                breathingActivity.GetDone();
            }

            else if (menuOption == 2) //Reflecting Activity
            {
                Console.Clear();
                //Console.WriteLine("Welcome to the Reflecting Activity.");
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", 0);
                reflectingActivity.GetActivityName();
                reflectingActivity.GetActivityDescription();
                seconds = reflectingActivity.GetDuration();
                reflectingActivity.GetReady();
                reflectingActivity.Reflecting(seconds);
                reflectingActivity.GetDone();
            }

            else if (menuOption == 3) //Listing Activity
            {
                Console.Clear();
                //Console.WriteLine("Welcome to the Listing Activity.");
                ListingActivity listingActivity = new ListingActivity("Listing", 0);
                listingActivity.GetActivityName();
                listingActivity.GetActivityDescription();
                seconds = listingActivity.GetDuration();
                listingActivity.GetReady();
                listingActivity.Listing(seconds);
                listingActivity.GetDone();
            }
        }
        
        if (menuOption == 4) //Quit
        {
            Console.Clear();
            Console.WriteLine("Quit");
        }        
    }
}