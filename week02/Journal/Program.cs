using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("\nWhat would you like to do: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"\n{prompt}");
                        Console.Write("");
                        string response = Console.ReadLine();
                        Entry newEntry = new Entry(prompt, response);
                        myJournal.AddEntry(newEntry);
                        break;

                    case "2":
                        myJournal.DisplayEntries();
                        break;

                    case "3":
                        Console.Write("Enter the file's name: ");
                        string fileToLoad = Console.ReadLine();
                        myJournal.LoadFromFile(fileToLoad);
                        break;

                    case "4":
                        Console.Write("File name: ");
                        string fileToSave = Console.ReadLine();
                        myJournal.SaveToFile(fileToSave);
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Option not valid please press enter to continue and choose a number from 1 to 5");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
