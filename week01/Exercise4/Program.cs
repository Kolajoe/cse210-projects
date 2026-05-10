using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter numbers to add to the list. type 0 to finish.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number:");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers you entered is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers you entered is {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
         Console.WriteLine($"The maximum number you entered is {max}");
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            } 
        }
        Console.WriteLine($"The smallest positive number you entered is {smallestPositive}");
        numbers.Sort();
        Console.WriteLine("The numbers you entered in sorted order are:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}