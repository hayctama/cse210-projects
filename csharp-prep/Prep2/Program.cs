using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string stringGrade = Console.ReadLine();
        int numGrade = int.Parse(stringGrade);

        string letter = "";


        if (numGrade >= 90)
        {
            letter = "A";
        }
        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
            letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (numGrade >= 70)
        {
            Console.WriteLine("You passed the course. Congrats! ");
        }
        else
        {
            Console.WriteLine("You didn't pass. Good luck next time! ");
        }

    }
}