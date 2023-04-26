using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter a number: ");

            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }    

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float avrg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avrg}");

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max number is: {maxNumber}");
    }
}