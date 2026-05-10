using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade?");
        int grade = int.Parse(Console.ReadLine());
        int lastDigit = grade % 10;
        string letterGrade = "";
        string sign ="";
        if (grade >= 70 && grade <= 100)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time.");
        }

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        if (letterGrade != "A" && letterGrade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign ="-";
            }
        }
        else if (letterGrade == "A")
        {
            if (grade % 10 <= 3 && grade <90)
            {
                sign = "-";
            }
        }
        if (sign =="")
        {
            Console.WriteLine($"Your letter grade is {letterGrade}.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letterGrade}{sign}.");
        }

    }
}