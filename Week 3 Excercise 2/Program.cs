using System;

class DiceRoller
{
    static void Main()
    {
        bool continueRolling = true; // states contionuerolling is true to keep the program going

        while (continueRolling)
        {
            // Rolls the dice to get the results
            (int die1, int die2) = RollDice();

            // Displays to the user the rolls they got
            Console.WriteLine($"You rolled a {die1} and a {die2}.");

            // Prompts the user if they want to roll again
            Console.Write("Do you want to roll again? (y/n): ");
            // takes users response 
            string response = Console.ReadLine().ToLower();
            if (response != "y")
            {
                continueRolling = false;
            }
        }
        // if user inputs "N" it thanks them for playing
        Console.WriteLine("Thank you for playing!");
    }

    static (int, int) RollDice()
    {
        Random random = new Random();

        // Rolls two dice
        int die1 = random.Next(1, 7); // Rolls a number between 1 and 6
        int die2 = random.Next(1, 7); // Rolls a number between 1 and 6

        return (die1, die2);
    }
}