using System;
using System.ComponentModel.Design;

class program
{
    static void Main()
    {
        //Ask user for thier name
        Console.WriteLine("Please enter your first name:");
        string firstName = Console.ReadLine();

        //Ask user if they want to participate in the challange
        Console.WriteLine(firstName + " , do you want to participate in the Coin Flip Challenge? (yes/no):");
        string userAnswer = Console.ReadLine();

        //what happens based on user selection
     
            // user selects not to participate
            if (userAnswer == "no") { 
            Console.WriteLine("You are a coward " + firstName + "!");
        }

        if (userAnswer == "yes")
        {
            Console.WriteLine("Excellent! Thanks for accepting to participate in the challange!");

            //variable for score
            int totalGuessedCorrect = 0;
            Random random = new Random();

            //number or rounds
            for (int round = 1; round <=5;  round++)
            {
                //pick a random number 0 or 1
                int randomNumber = random.Next(2);

                //ask user to pick heads or tails
                Console.WriteLine("Please guess and enter heads or tails:");
                string userGuess = Console.ReadLine();

                //user guess compared to random number
                if (userGuess == "heads" && randomNumber == 0) {
                    Console.WriteLine("Your guess is correct!");
                    totalGuessedCorrect++;
                }
                    
                else if (userGuess == "tails" && randomNumber == 1) {
                    Console.WriteLine("Your guess is correct!");
                    totalGuessedCorrect++;
                }
                  
                else
                {
                    Console.WriteLine("Your guess is incorrect!");
                }
                
              }
            // total correct guesses
            Console.WriteLine(firstName + ", you got " + totalGuessedCorrect + " out of 5 correct guesses!");
           
         
            }
        }
    }
