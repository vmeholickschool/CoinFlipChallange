using System;
using System.ComponentModel.Design;

string yes = "yes";
string no = "no";
int heads = 0;
int tails = 1;
int headFlips = 0;
int tailFlips = 1;

//Ask user for thier name
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

//Ask user if they want to participate in the challange
Console.WriteLine(name + " , do you want to participate in the Coin Flip Challenge? (yes/no):");
string userAnswer = Console.ReadLine();

//what happens based on user selection

// user selects not to participate
if (userAnswer.Equals(no, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("You are a coward " + name + "!");
}

if (userAnswer.Equals(yes, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Excellent! Thanks for accepting to participate in the challange!");

    //variable for score
    int totalGuessedCorrect = 0;
    Random random = new Random();

    //number or rounds
    for (int round = 1; round <= 5; round++)
    {
        //pick a random number 0 or 1
        int randomNumber = random.Next(2);

        //ask user to pick heads or tails
        Console.WriteLine("Please guess and enter heads or tails:");


        //user guess compared to random number
        string userGuess;
        userGuess = Console.ReadLine();

        if (userGuess.Equals(heads, StringComparison.OrdinalIgnoreCase) && randomNumber == headFlips)
        {
            Console.WriteLine("Your guess is correct!");
            totalGuessedCorrect++;
        }

        else if (userGuess.Equals(tails, StringComparison.OrdinalIgnoreCase) && randomNumber == tailFlips)
        {
            Console.WriteLine("Your guess is correct!");
            totalGuessedCorrect++;
        }

        else
        {
            Console.WriteLine("Your guess is incorrect!");
        }

    }
    // total correct guesses
    Console.WriteLine(name + ", you got " + totalGuessedCorrect + " out of 5 correct guesses!");


}
