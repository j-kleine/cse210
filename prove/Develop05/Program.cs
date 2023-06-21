using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        ManageGoals goals = new ManageGoals();

        Console.Clear();

        Console.WriteLine($"You have {goals.GetTotalPoints()} points.");
        Console.WriteLine();

        Menu menu = new Menu();
        GoalMenu goalMenu = new GoalMenu();

        int menuOption = 0;
        int goalMenuOption = 0;

        while (menuOption != 6)
        {
            menuOption = menu.UserChoice();

            if (menuOption == 1) //Create New Goal
            {
                Console.Clear();
                goalMenuOption = goalMenu.UserChoice();

                while (goalMenuOption != 4)
                {
                    if (goalMenuOption == 1) //Create Simple Goal
                    {

                    }

                    else if (goalMenuOption == 2) //Create Eternal Goal
                    {

                    }

                    else if (goalMenuOption == 3) //Create Checklist Goal
                    {

                    }
                }

                if (goalMenuOption == 4)
                {
                    Console.Clear();
                    Console.Write("Going back to Main Menu");
                    Thread.Sleep(500);
                    Console.Write($"\rGoing back to Main Menu.");
                    Thread.Sleep(500);
                    Console.Write($"\rGoing back to Main Menu..");
                    Thread.Sleep(500);
                    Console.Write($"\rGoing back to Main Menu...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            else if (menuOption == 2) //List Goal
            {

            }

            else if (menuOption == 3) //Save Goals
            {

            }

            else if (menuOption == 4) //Load Goals
            {

            }

            else if (menuOption == 5) //Record Event
            {

            }
        }

        if (menuOption == 6) //Quit
        {
            Console.Clear();
            Console.Write("Quitting Program");
            Thread.Sleep(500);
            Console.Write($"\rQuitting Program.");
            Thread.Sleep(500);
            Console.Write($"\rQuitting Program..");
            Thread.Sleep(500);
            Console.WriteLine($"\rQuitting Program...");
            Thread.Sleep(500);
            Console.WriteLine("The program has ended.");
            Thread.Sleep(1000);
            Console.Clear();
        } 
    }
}