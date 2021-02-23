using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    int favNumber = 42;  // while loop if unknown number of tries

        //    Console.WriteLine("For today's magic trick for the birhday boy, I want you to guess my favorite number.  My number is betwee 1 and 75");
        //    int userGuess = int.Parse(Console.ReadLine());

        //    if (userGuess < favNumber)
        //    {
        //        Console.WriteLine("Too low!!");
        //    }
        //    else if (userGuess > favNumber)
        //    {
        //        Console.WriteLine("Too high!!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nevermind, you read minds");
        //    }
        { 
        Console.WriteLine("Tell me what is your favorite class.");
            string userSubject = Console.ReadLine();

            switch (userSubject.ToLower())
            {
            case "math":
                Console.WriteLine("Math - very square");
                break;
            case "geology":
                Console.WriteLine("Geology  - rock N' roll");
                break;
            case "English":
                Console.WriteLine("English - that's poetic");
                break;
            case "scinece":
                Console.WriteLine("Science - how explosive!");
                break;
            case "world history":
                Console.WriteLine("World History - very intriguing");
                break;
            case "computer science":
                Console.WriteLine("Computer Science - arrrggghhhhhh");
                break;
             default:
                Console.WriteLine("Whatever!  Take a real class!");
                    break;
            }
        }
    

    }
}
