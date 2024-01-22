using System;

public class RollDice
{
    public int[] Simulator(int diceRolls)
    {
        Random random = new Random();

        //variables to hold what number was rolled 
        int diceOne = 0;
        int diceTwo = 0;
        int total = 0;
        int maxTotal = 12;
        //sets how many sided dice it is
        int min = 1;
        int max = 7;

        //arrary to hold results
        int[] results = new int[maxTotal - 1];

        //simulates however many rolls that the user wants to do 
        for (int i = 0; i < diceRolls; i++)
        {
            diceOne = random.Next(min, max);
            diceTwo = random.Next(min, max);
            total = diceOne + diceTwo;

            //it is the total - 2 since the lowest possible roll is a 2
            results[total - 2] = results[total - 2] + 1;
        }

        return results;
    }
}
