using System;

class Program
{
    static void Main(string[] args)
    {
      
        Reference reference = new Reference("Proverbs", 3, 5,6);


        string scriptureText = "Trust in the LORD with all your heart and lean not on your own understanding." +
                                "In all your ways acknowledge him, and he will make your paths straight.";


        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(3); //hides 3 randomly

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words have been hidden. Well done!");
                break;
            }
        }
    }
}
