// See https://aka.ms/new-console-template for more information
using Mission1;

// initialize dice variables;
int totalDiceRolls = 0;
string input = "";
RollDice rolling = new RollDice();

Console.WriteLine("Welcome to the dice throwing simulator!");
Console.WriteLine();
// ask user how many times to roll
Console.WriteLine("How many dice rolls would you like to simulate?");
input = Console.ReadLine();
Console.WriteLine();
totalDiceRolls = int.Parse(input);

// use rolldice class to roll number of times user input
int[] rolls = rolling.RollBothDice(totalDiceRolls);

Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
Console.WriteLine("Total number of rolls: " + totalDiceRolls + ".");
Console.WriteLine();

// for each number in the array
for (int roll = 0; roll < rolls.Length; roll++)
{
    // create a string for the number
    string rollstring = (roll + 2).ToString() + ": ";
    int i = 0;
    // calculate the percentage of time each num was rolled
    double rollPercentage = ((double)rolls[roll] / totalDiceRolls) * 100;
    
    // print an asterisk for every 1 percent it was rolled
    while (i < rollPercentage)
    {
        // add an asterisk for each to the string
        rollstring += "*";
        i++;
    }
    // print full string
    Console.WriteLine(rollstring);
   
}

Console.WriteLine();
Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    
    
    
