namespace Mission1;


public class RollDice()
{
    public int[] RollBothDice(int totalRolls)
    {
        // initialize vairables
        Random random = new Random();
        int[] rolltotalsarray = new int[11];
        int die1 = 0;
        int die2 = 0;
        int rolltotal = 0;
    
        // for num of times user entered
        for (int i = 0; i < totalRolls; i++)
        {

            // roll die 1 and store number
            die1 = random.Next(1, 7);
            // roll die 2 and store number
            die2 = random.Next(1, 7);

            // add the numbers together to get the total and increment the count for that number
            rolltotal = die1 + die2;
            rolltotalsarray[(rolltotal - 2)]++;

          
        }
    
     
        // return array
        return rolltotalsarray;
    }
}

