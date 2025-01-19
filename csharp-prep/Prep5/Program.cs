using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        int number;

        Console.Write("What is your favorite number? ");
        number = Int32.Parse(Console.ReadLine());

        int squared = number * number;

        Console.WriteLine($"Your total is name is {name} and your favorite number squared is {squared}. ");
    }
}