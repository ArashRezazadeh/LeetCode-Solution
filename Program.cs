using System.ComponentModel.Design;

Console.WriteLine("Select which solution to execute:");
Console.WriteLine("1. TwoSum");
Console.WriteLine("1. TwoSum");
Console.Write("Enter your choice (1-75): ");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Description");
        Console.WriteLine("========================================================");
        Console.WriteLine("\nGiven an array of integer nums and an integer target, return");
        Console.WriteLine("\nindices of the two numbers such that they add up to the target.");
        Console.WriteLine("\nYou may assume that each input would have exactly one solution,");
        Console.WriteLine("\nand you may not use the same element twice.");
        Console.WriteLine("\nYou can return the answer in any order.");
        Console.WriteLine("========================================================");

        int targetNumb = GetValidInteger("Enter Target: ");

        int[] nums = UserArrayCreator();
        int[] result = TwoSum(nums, targetNumb);

        Console.WriteLine($"\nArray as string: [{string.Join(", ", nums)}] , target: {targetNumb}");
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");

        break;
    case "2":
        Console.WriteLine("Description");
        Console.WriteLine("========================================================");
        Console.WriteLine("\nYou are given an array of prices where prices[i] is the price of a");
        Console.WriteLine("\ngiven stock on an ith day. You want to maximize your profit by choosing a single day to buy");
        Console.WriteLine("\none stock and choosing a different day in the future to sell that stock.");
        Console.WriteLine("\nReturn the maximum profit you can achieve from this transaction.");
        Console.WriteLine("\nIf you cannot achieve any profit, return 0");
        Console.WriteLine("========================================================");

        int[] prices = UserArrayCreator();
        int result2 = MaxProfit(prices);

        Console.WriteLine($"\nArray as string: [{string.Join(", ", prices)}]");
        Console.WriteLine($"Maximum Profit: {result2}");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}


static int[] UserArrayCreator()
{
    Console.WriteLine("=== Array Creator ===");

    int[] numbers = CreateArrayFromUserInputs();

    Console.WriteLine($"\nArray as string: [{string.Join(", ", numbers)}]");

    return numbers;
}

static int GetValidInteger(string message)
{
    int number = 0;
    bool validNumber = false;

    while (!validNumber)
    {
        Console.Write(message);
        string lengthInput = Console.ReadLine();

        if (int.TryParse(lengthInput, out number) && number > 0)
        {
            validNumber = true;
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
        }
    }

    return number;
}

static int[] CreateArrayFromUserInputs()
{
    int length = GetValidInteger("\nEnter the length of the array: ");

    int[] array = new int[length];

    Console.WriteLine($"\nYou will now enter {length} number(s)");

    for (int i = 0; i < length; i++)
    {
        array[i] = GetValidInteger($"Enter number for position {i}: ");
    }

    return array;
}

static int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            // Check if the pair sums to target
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }


    return new int[] { -1, -1 };
}

static int MaxProfit(int[] prices)
{
    int maxProfit = 0;

    // Outer loop: iterate through each day as potential buy day
    for (int i = 0; i < prices.Length; i++)
    {
        // Inner loop: iterate through future days as potential sell days
        for (int j = i + 1; j < prices.Length; j++)
        {
            // Calculate profit if we buy on day i and sell on day j
            int profit = prices[j] - prices[i];

            // Update maxProfit if this transaction yields higher profit
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
    }

    return maxProfit;
}