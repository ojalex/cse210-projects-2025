using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference object for the scripture to memorize
        Reference reference = new Reference("John", 3, 16);

        // Scripture text to memorize
        string scriptureText = "For God so loved the world that He gave His one and only Son, " +
                               "that whoever believes in Him shall not perish but have eternal life.";

        // Create a Scripture object, passing in the reference and the scripture text
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide some words, or type 'quit' to exit.");

        while (true)
        {
            // Display the scripture with hidden and visible words
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

            // Read user input
            string input = Console.ReadLine();

            // If user types "quit", exit the program
            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            // Hide 3 random words each time Enter is pressed
            scripture.HideRandomWords(3);

            // Check if all words are hidden, if so end program
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
