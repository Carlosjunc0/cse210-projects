using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptureLibrary library = new ScriptureLibrary();
            Scripture scripture = library.GetRandomScripture();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("\nAll words have been hidden. End of program.");
                    break;
                }

                Console.WriteLine("\nPress ENTER to continue or type 'quit' to finish.");
                string input = Console.ReadLine().Trim().ToLower();

                if (input == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3);
            }
        }
    }
}