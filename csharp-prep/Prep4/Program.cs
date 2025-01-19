using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userInput;

        int total = 0;

        int bn = 0;

        do
        {
            Console.Write("Please add an interger. ");
            userInput = Int32.Parse(Console.ReadLine());
            numbers.Add(userInput);
        } while (userInput != 0);

        foreach (int number in numbers)
        {
            total += number;
        }

        int userEntries = numbers.Count;
        int average = total / userEntries;

        foreach (int number in numbers)
        {
            if (number > bn)
            {
                bn = number;
            }
        }

        Console.WriteLine($"Your total is {total}. Your average is {average}. Your greatest number is {bn}");
    }
}