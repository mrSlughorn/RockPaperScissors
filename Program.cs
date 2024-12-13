// See https://aka.ms/new-console-template for more information

using System;

int userPoints = 0;
int pcPoints = 0;

while (true)
{
    Game(ref userPoints, ref pcPoints);
    
}


static void Game(ref int userPoints, ref int pcPoints)
{
    Thread.Sleep(1500);
    Console.WriteLine("Welcome to Rock, Paper, Scissors." + "\n" + "Please select a number.." + "\n");
    Console.WriteLine("1. Rock" + "\n" + "2. Paper" + "\n" + "3. Scissors" +"\n" + "4. Quit the game");

    try
    {
        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice);
        Random rnd = new Random();
        int rndMove = rnd.Next(1, 4);

        if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
        {
            Console.WriteLine("Not a valid number. Try again.." + "\n");
        }
        
        else if (choice == 4)
        {
            Console.WriteLine("Quitting game..");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("\n" + "You chose: " + choice + " the computer chose: " + rndMove);
            CheckVictory(choice, rndMove, ref userPoints, ref pcPoints);
            
        }
    }
    catch (FormatException ex) // this happens if the user writes something that isn't an integer
    {
        Console.WriteLine($"Error: Enter a valid number. {ex.Message}" + "\n");

    }

}

static void CheckVictory(int choice, int rndMove, ref int userPoints, ref int pcPoints)
{
    if ((choice - rndMove + 3) % 3 == 1)
    {
        userPoints++;
        Console.WriteLine("You won! You now have " + userPoints + " points" + "\n");
       

    }

    else if ((choice - rndMove + 3) % 3 == 2)
    {
        pcPoints++;
        Console.WriteLine("You lost. The computer now has " + pcPoints + " points" + "\n");
    }

    else if ((choice - rndMove + 3) % 3 == 0)
    {
        Console.WriteLine("It's a tie!" + "\n");
    }
}