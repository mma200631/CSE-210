//Exceded requirement by adding a list of more scriptures
using System;

class Program
{
    static void Main(string[] args)
    {
         List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Refrence("John", 3, 16), "For God so loved the world that he gave his only begotten Son..."),
            new Scripture(new Refrence("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding...")
        
        };
        
        // Select a random scripture
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];
        
        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit") break;
            
            selectedScripture.HideRandomWords();
        }
    }
    
}