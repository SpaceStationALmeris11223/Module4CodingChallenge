// Program generates a random number between 1 and 100
using System;

Console.WriteLine("Welcome to the random number guesser.");
Console.WriteLine("The Computer is now thinking of a number between 1-100. Guess what number it chose");
int playerChoice;
Random random = new Random();
int targetNumber = random.Next(1, 101);
do{
playerChoice = int.Parse(Console.ReadLine());
    if (playerChoice < targetNumber){
        Console.WriteLine($"Your number is {playerChoice}, you're too low.");
        Console.WriteLine("Try again");
    }
    if (playerChoice > targetNumber){
        Console.WriteLine($" Your number is {playerChoice}, you're too high.");
        Console.WriteLine("Try again");

    }
}
while(playerChoice != targetNumber);
Console.WriteLine($"Your number is {playerChoice}, You go it right nice guess hot shot!");