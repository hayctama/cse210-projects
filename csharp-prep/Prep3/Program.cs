using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // Used part 1 and 2.
        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 11);

        int guess = -100;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            string letter = "";

            if (magicNum > guess)
            {
                letter = "higher";
            }
            else if (magicNum < guess)
            {
                letter = "lower";
            }
            else
            {
                letter = "You guessed it!";
            }

            Console.WriteLine(letter);
        }

        
    }
}