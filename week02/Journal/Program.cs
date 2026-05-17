using System;

namespace JournalProgram
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
            {
                Console.WriteLine("==== JOURNAL MENU ====");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.WriteLine("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                         string prompt = promptGen.GetRandomPrompt();
                         Console.WriteLine($"\nPrompt: {prompt}");
                         Console.Write("Your response");
                         string response = Console.ReadLine();
                         Console.Write("How are you feeling today?");

                         string mood = Console.ReadLine();
                         string date = DateTime.Now.ToShortDateString();
                         Entry newEntry = new Entry(date, prompt, response, mood);
                         journal.AddEntry(newEntry);
                         Console.WriteLine("Entry added!\n");
                         break;

                    case "2":
                         Console.WriteLine("\n--- All Entries ---");
                         journal.DisplayAll();
                         break;

                    case "3":
                         Console.Write("Enter filename to save (e.g., journal.txt):");
                         string saveFile = Console.ReadLine();
                         journal.SaveToFile(saveFile);
                         break;

                    case "4":
                         Console.Write("Enter filename to load: ");
                         string loadFile = Console.ReadLine();
                         journal.LoadFromFile(loadFile);
                         break;

                    case "5":
                         running = false;
                         Console.WriteLine("Goodbye!");
                         break;
                    default:
                         Console.WriteLine("Invalid option, try again.\n");
                         break;
                }
            }
    }
   }  
}
