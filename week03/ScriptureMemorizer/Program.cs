using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("Proverbios", 3, 5, 6);
            string text = "Confía en el Señor con todo tu corazón y no te apoyes en tu propio entendimiento.";
            Scripture scripture = new Scripture(reference, text);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("\nTodas las palabras han sido ocultadas. ¡Fin del programa!");
                    break;
                }

                Console.WriteLine("\nPresiona ENTER para ocultar más palabras o escribe 'quit' para salir.");
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