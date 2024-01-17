using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //holds however many rolls that the user wants to simulate
        int diceRolls = 0;
        //holds the results that will be returned when RollDice function is called
        int[] results;

        Console.WriteLine("Welcome to the dice throwing simulator!\n");

        //Gets the user input and converts the input from string to integer
        Console.WriteLine("How Many dice rolls would you like to simulate?");
        diceRolls = int.Parse(Console.ReadLine());

        //Just some code so that it matches the format of the assignment, changes dynamically based on user input for 
        //number of rolls 
        Console.WriteLine("\nDICEROLLING SIMULATION RESULTS\n" +
                            "Each \"*\" represent 1% of the total number of rolls\n" +
                            "Total number of rolls = " + diceRolls + "\n");

        //calls the function that actually rolls the dice
        results = RollDice(diceRolls);

        //loops through the results and dynamically makes the histogram
        for (int i = 0; i < results.Length; i++)
        {
            int percentage = (results[i] * 100) / diceRolls;
            Console.Write($"{i + 2}: {new string('*', percentage)}");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    private static int[] RollDice(int diceRolls)
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

    