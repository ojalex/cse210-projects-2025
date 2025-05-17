using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //C# Programming Exercise 4: Lists and Generics

        List<int> numbers = new List<int>();//List named numbers

        int userNumber = -1;//This  will allow while loop to start since userNumber is not equals to 0
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // The sum of numbers in the list
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number; //sums the numbers in the list
        }

        Console.WriteLine($"The sum is: {sum}"); // displays the sum

        // The average on numbers in the list 
        float average = ((float)sum) / numbers.Count;// since avarage may have decimals, I used float
        Console.WriteLine($"The average is: {average}");

        // Find the max number
        int max = numbers[0];//sets max number to number under index 0 the first number in the list

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max 1st number in the list,  new max is found.
                max = number;
            }
        }

        // Find the min number
        int min = numbers[0];//sets min number to number under index 0 the first number in the list

        foreach (int number in numbers)
        {
            if (number < min )
            {
                // if this number is less than the min 1st number in the list,  new min is found.
                min = number;
            }
        }

        Console.WriteLine($"The min number is: {min}");
        Console.WriteLine($"The max is: {max}");

        //Sorting numbers in the list
        numbers.Sort();

        // Print the sorted list
        foreach (int number in numbers)
        {
            Console.WriteLine(number + " ");
        } 

    }
}