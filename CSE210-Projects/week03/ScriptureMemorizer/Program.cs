using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Refrence reference = new Refrence("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding;";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program complete!");
                break;
            }

            Console.Write("\nPress Enter to hide words or type 'quit' to exit: ");
            string userInput = Console.ReadLine()?.Trim().ToLower();
            if (userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords();
        }
    }
}