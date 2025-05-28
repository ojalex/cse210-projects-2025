using System;

class Program
{
    static void Main(string[] args)
    {
        //C# Programming Exercise 3: Loops by Alex Juma
        //###############################################

        //MY NOTES FROM THE TOPIC 
        //Creating a List
        //--------------------------------
        //List<string> colors= new List<string>();
        //colors.Add("Red");
        //colors.Add("Yellow");
        // colors.Add("Blue");

        //foreach loop
        //--------------------------------
        //foreach (string color in colors)
        //{
        //    Console.WriteLine(color);
        //}

        //for loop
        //----------------------------------
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write(i);
        //}
        //string response;

        //do while
        //-----------------------
        //do
        //{
        //    Console.WriteLine("Do you want to continue? ");
        //    response = Console.ReadLine();
        //} 
        //while (response == "yes");

        //Rando Number  generation
        //------------------------
        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);

        //ASSIGNMEN
        //######################################################################
        //I have decided to use Random number between 1 to 10 and made the game hard
        //by generating random number after every failed attempts and not just 
        //generating the random number once.
        Random randNumber = new Random();
        int magicNumber = randNumber.Next(1, 101);
        int yourGuess = -1; //set initial guess to -1 which is out of range to enable the loop start from begining
        string text = "";
        int numberOfGuess = 0;
        
        while (yourGuess != magicNumber)
            {
                Console.WriteLine($"What is the magic number? {magicNumber}");
                Console.Write($"What is your guess? ");
                string guess = Console.ReadLine();
                yourGuess = int.Parse(guess);

                numberOfGuess = numberOfGuess + 1;

                if (yourGuess < magicNumber)
                { 
                    text = "Lower";
                }
                else if (yourGuess > magicNumber)
                {
                    text = "Higher";
                }
                else
                {
                    text = $"You guessed it! after {numberOfGuess} trials.";
                }
                
                Console.WriteLine($"{text}");
                Console.WriteLine();
            }

        

    }
}