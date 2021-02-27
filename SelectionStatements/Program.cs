using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 42;  // while loop if unknown number of tries

            Console.WriteLine("For today's magic trick for the birhday boy, I want you to guess my favorite number.  My number is betwee 1 and 75");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favNumber)
            {
                Console.WriteLine("Too low!!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine("Too high!!");
            }
            else
            {
                Console.WriteLine("Nevermind, you read minds");
            }

        }
    

    }
}
