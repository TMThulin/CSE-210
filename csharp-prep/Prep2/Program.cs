using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        int letter = 0;

        if (grade >= 90)
        {
            letter = 9;
        }
        else if (grade >= 80)
        {
            letter = 8;
        }
        else if (grade >= 70)
        {
            letter = 7;
        }
        else if (grade >= 60)
        {
            letter = 6;
        }
        else
        {
            letter = 1;
        }

        if (letter == 9)
        {
            Console.WriteLine("A");
        }
        else if (letter == 8)
        {
            Console.WriteLine("B");
        }
        else if (letter == 7)
        {
            Console.WriteLine("C");
        }
        else if (letter == 6)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (letter >= 7)
        {
            Console.WriteLine("Keep up the great work!");
        }
        else
        {
            Console.WriteLine("You can do better");
        }

    }
}