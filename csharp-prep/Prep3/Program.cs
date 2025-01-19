using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenarator = new Random();
        int number = randomGenarator.Next(1,100);

        int userInput;

        do
        {
            Console.Write("Please guess a number. ");
            userInput = Int32.Parse(Console.ReadLine());

            if (userInput > number)
            {
                Console.WriteLine("Guess lower. ");
            }
            else if (userInput < number)
            {
                Console.WriteLine("Guess higher. ");
            }
            else if (userInput == number)
            {
                Console.WriteLine("You got it! ");
            }

        } while (userInput != number);

    }
}