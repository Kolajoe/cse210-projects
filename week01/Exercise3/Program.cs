using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        string playAgain = "y";

        while (playAgain == "y")
        {
             Random randomGenerator = new Random();

             int magicNumber = randomGenerator.Next(1, 101);

             int guess = 0;
             int attempts = 0;

             while (guess != magicNumber)
            {
                Console.Write("Enter your guess (1-100):");
                guess = int.Parse(Console.ReadLine());
                attempts++;
            
                if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the magic number! It took {attempts} guesses.");
                }   
            }
            Console.Write("Do you want to play again? (y/n)");
            playAgain = Console.ReadLine().ToLower();
        }
            Console.WriteLine("Thank you for playing the Magic Number Game! Goodbye!");
    }      
}