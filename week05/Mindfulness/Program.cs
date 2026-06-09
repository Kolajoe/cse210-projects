using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Show Session Summary");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RunActivity(new BreathingActivity(), "Breathing Activity");
                    break;
                case "2":
                    RunActivity(new ReflectionActivity(), "Reflection Activity");
                    break;
                case "3":
                    RunActivity(new ListingActivity(), "Listing Activity");
                    break;
                case "4":
                    ActivityLogger.ShowSummary();
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for using the Mindfulness Program. Stay mindful!");
    }

    static void RunActivity(Activity activity, string activityName)
    {
        activity.Start();
        ActivityLogger.LogActivity(activityName);
    }
}