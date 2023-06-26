// To show creativity and exceed requirements, I added a Level class to my program.
// The amount of needed (experience) points scales with the level, and the current
// level is displayed together with the current points the user has.
// I also did a few minor changes to the UI and wording to try to make the program
// more "intuitive"

using System;
using System.IO;
using System.Threading;


class Program
{
    static void Main(string[] args)
    {
        ManageGoals goals = new ManageGoals();

        Console.Clear();

        Console.WriteLine("--- Welcome to your Eternal Quest ---");

        Menu menu = new Menu();
        GoalMenu goalMenu = new GoalMenu();

        int menuOption = 0;
        int goalMenuOption = 0;

        while (menuOption != 6)
        {
            //Console.WriteLine($"You have {goals.GetTotalPoints()} points.");
            Console.WriteLine();
            menuOption = menu.UserChoice();

            if (menuOption == 1) //Create New Goal
            {
                Console.Clear();
                goalMenuOption = goalMenu.UserChoice();

                while (goalMenuOption != 4)
                {
                    if (goalMenuOption == 1) //Create Simple Goal
                    {
                        string goalType = "Simple Goal";
                        Console.Write($"What is the name of your {goalType}? > ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of it? > ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? > ");
                        int points = int.Parse(Console.ReadLine());

                        SimpleGoal simpleGoal = new SimpleGoal(goalType, name, description, points, 0);
                        goals.AddGoal(simpleGoal);
                        goalMenuOption = 4;
                    }

                    else if (goalMenuOption == 2) //Create Eternal Goal
                    {
                        string goalType = "Eternal Goal";
                        Console.Write($"What is the name of your {goalType}? > ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of it? > ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? > ");
                        int points = int.Parse(Console.ReadLine());

                        EternalGoal eternalGoal = new EternalGoal(goalType, name, description, points, 0);
                        goals.AddGoal(eternalGoal);
                        goalMenuOption = 4;
                    }

                    else if (goalMenuOption == 3) //Create Checklist Goal
                    {
                        string goalType = "Checklist Goal";
                        Console.Write($"What is the name of your {goalType}? > ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of it? > ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? > ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? > ");
                        int numberTimes = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? > ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        int count = 0;

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalType, name, description, points, bonusPoints, numberTimes, count);
                        goals.AddGoal(checklistGoal);
                        goalMenuOption = 4;
                    }
                }

                if (goalMenuOption == 4)
                {
                    Console.Clear();
                    Console.Write("Going back to Main Menu");
                    Thread.Sleep(400);
                    Console.Write($"\rGoing back to Main Menu.");
                    Thread.Sleep(400);
                    Console.Write($"\rGoing back to Main Menu..");
                    Thread.Sleep(400);
                    Console.Write($"\rGoing back to Main Menu...");
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("--- Welcome to your Eternal Quest ---");
                }
            }

            else if (menuOption == 2) //List Goal(s)
            {
                Console.Clear();
                goals.ListGoals();
            }

            else if (menuOption == 3) //Save Goal(s)
            {
                Console.Clear();
                goals.SaveGoals();
            }

            else if (menuOption == 4) //Load Goal(s)
            {
                Console.Clear();
                goals.LoadGoals();
            }

            else if (menuOption == 5) //Record Event
            {
                Console.Clear();
                goals.RecordGoalEvent();
            }
        }

        if (menuOption == 6) //Quit
        {
            Console.Clear();
            Console.Write("Quitting Program");
            Thread.Sleep(400);
            Console.Write($"\rQuitting Program.");
            Thread.Sleep(400);
            Console.Write($"\rQuitting Program..");
            Thread.Sleep(400);
            Console.WriteLine($"\rQuitting Program...");
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("The program has ended.");
            Thread.Sleep(1000);
            Console.Clear();
        } 
    }
}