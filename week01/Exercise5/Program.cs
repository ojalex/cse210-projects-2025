using System;

class Program
{
    static void Main(string[] args)
    {
        //C# Programming Exercise 5: Functions
        DisplayWelcomeMessage();

        string userName = PromptUserName();//save users input name to string variable userName by calling function PronmptUserName
        int userNumber = PromptUserNumber();//save users input number to integer variable userNumber by calling function PronmptUserNumber

        int squaredNumber = SquareNumber(userNumber);//passes userNumber input SquareNumber function and retun squared saved as squareNumber int

        DisplayResult(userName, squaredNumber);//Calls the DisplayResult function and prints name and square
    }

    static void DisplayWelcomeMessage() //fucntion to display welcome text
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()//function to prompt user's Full Name
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber() //function to prompt user's favourite number 
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());//convert user input to integer

        return number;
    }

    static int SquareNumber(int number) //fuction that calculates the square of the user's input number
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square) //function that displays the results
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}