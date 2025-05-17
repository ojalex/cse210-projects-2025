using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //C# Programming Exercise 2: Conditionals by Alex Otieno Juma
        Console.Write("What percentage did you score: "); //asks the user their score in %
        string userScore = Console.ReadLine(); //picks users input
        int score = int.Parse(userScore); //convert user input to intager
        
        //defing variables; grade, grade sign, lastDigit, text
        string grade =""; 
        int lastDigit = score % 10; //picks the last digit
        string gradeSign = "";
        string text = "";

        //evaluating users performance and grading
        if (score >= 90)
        {
            grade = "A"; 
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D"; 
        }
        else 
        {
            grade = "F";
        }
        
        // evaluating users grade digit and assigning sign
        if(score>=90 ){
            if (lastDigit < 3){
                gradeSign = "-";
            }
            else{
                gradeSign = "";
            }
        }
        if(score < 90){  
            if (lastDigit >= 7){
                gradeSign = "+";
            }
            else if (lastDigit < 3){
                gradeSign = "-";
            }
            else{
                gradeSign = "";
            }
        }

        // evaluating users grade and displaying appropriate text
        if (score >= 70){
            text = "Congratulations you have passed your test.";
        }
        else{
            text = "Sorry but you did not do well try again next time";
        }


        
        // printing the text, grade and grade sign
       Console.WriteLine($"{text} You scored {grade}{gradeSign}");
    }
}