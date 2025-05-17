using System;

class Program
{
    static void Main(string[] args)
    {
        //C# Programming Exercise 1: Variable, input and output by Alex Juma

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
    }
}