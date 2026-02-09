using System.ComponentModel.Design;

Console.WriteLine("Select which solution to execute:");
Console.WriteLine("1. TwoSum");
Console.WriteLine("2. Max Profit");
Console.WriteLine("3. Contains Duplicate");
Console.WriteLine("4. Product of Array Except Self");
Console.WriteLine("5. Kadane's Algorithm(MaxSubArray)");
Console.WriteLine("6. MaxProduct(Multiplication)");
Console.WriteLine("7. Minimum in Sorted Array");
Console.WriteLine("8. Search in rotates sorted array");
Console.WriteLine("9. Three Sum Problem");


Console.Write("Enter your choice (1-75): ");

string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Description");
        Console.WriteLine("========================================================");
        Console.WriteLine("\nGiven an array of integer numbers and an integer target, return");
        Console.WriteLine("\nindices of the two numbers such that they add up to the target.");
        Console.WriteLine("\nYou may assume that each input would have exactly one solution,");
        Console.WriteLine("\nand you may not use the same element twice.");
        Console.WriteLine("\nYou can return the answer in any order.");
        Console.WriteLine("========================================================");

        int targetNumb = GetValidInteger("Enter Target: ");

        int[] numbers = UserArrayCreator();
        int[] result = TwoSum(numbers, targetNumb);

        Console.WriteLine($"\nArray as string: [{string.Join(", ", numbers)}] , target: {targetNumb}");
        Console.WriteLine($"Output: [{result[0]}, {result[1]}]");

        break;
    case "2":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\nYou are given an array of prices where prices[i] is the price of a");
        Console.WriteLine("\ngiven stock on an ith day. You want to maximize your profit by choosing a single day to buy");
        Console.WriteLine("\none stock and choosing a different day in the future to sell that stock.");
        Console.WriteLine("\nReturn the maximum profit you can achieve from this transaction.");
        Console.WriteLine("\nIf you cannot achieve any profit, return 0");
        Console.WriteLine(" ======================================================== ");

        int[] prices = UserArrayCreator();
        int result2 = MaxProfit(prices);

        Console.WriteLine($"\nArray as string: [{string.Join(", ", prices)}]");
        Console.WriteLine($"Maximum Profit: {result2}");
        break;
    case "3":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\nGiven an integer array numbers, return true if any value appears at");
        Console.WriteLine("\nleast twice in the array, and return false if every element is distinct.");
        Console.WriteLine(" ======================================================== ");

        int[] array = UserArrayCreator();
        bool result3 = ContainsDuplicate(array);

        Console.WriteLine($"\nArray as string: [{string.Join(", ", array)}]");
        Console.WriteLine($"Contains Duplicate: {result3}");
        break;
    case "4":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\nGiven an integer array numbers, return an array answer such that answer[i] ");
        Console.WriteLine("\nis equal to the product of all the elements of numbers except numbers[I]. The product");
        Console.WriteLine("\nof any prefix or suffix of numbers is guaranteed to fit in a 32-bit integer.");
        Console.WriteLine(" ======================================================== ");

        // Input: [ 1, 2, 3, 4]
        // Output: [24, 12, 8, 6]
        // Explanation: 
        // answer[0] = 2*3*4 = 24
        // answer[1] = 1*3*4 = 12
        // answer[2] = 1*2*4 = 8
        // answer[3] = 1*2*3 = 6

        int[] array4 = UserArrayCreator();
        int[] result4 = ProductExpectSelf(array4);

        Console.WriteLine($"\nInput: [{string.Join(", ", array4)}]");
        Console.WriteLine($"Output: [{string.Join(", ", result4)}]");

        break;
    case "5":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\ngive an integer array numbers, find the subarray with the largest sum, and retun its sum");
        Console.WriteLine(" ======================================================== ");

        int[] array5 = UserArrayCreator();
        int result5 = MaxSubArray(array5);

        Console.WriteLine($"\nInput: [{string.Join(", ", array5)}]");
        Console.WriteLine($"Output: {result5}");


        break;
    case "6":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\ngiven an integer array numbers. find a subarray that has largest product(MULTIPLICATION) and return the product!");
        Console.WriteLine(" 1.Take a contiguous block of numbers from the array (a subarray)");
        Console.WriteLine(" 2.Multiply all the numbers in that block together");
        Console.WriteLine(" 3.Find which block gives you the biggest result when multiplied");
        Console.WriteLine(" ======================================================== ");

        int[] array6 = UserArrayCreator();
        int result6 = MaxProduct(array6);

        Console.WriteLine($"\nInput: [{string.Join(", ", array6)}]");
        Console.WriteLine($"Output: {result6}");

        break;
    case "7":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\nFind the Minimum in Rotated Sorted Array");
        Console.WriteLine(" We use binary search to achieve O(log n) time complexity");
        Console.WriteLine(" In a rotated sorted array, the minimum element is the only element that is smaller than both its neighbors");
        Console.WriteLine(" How it works:");
        Console.WriteLine(" * Compare the middle element with the rightmost element");
        Console.WriteLine(" * If numbers[mid] > numbers[right], the minimum must be in the right half");
        Console.WriteLine(" * Otherwise, the minimum must be in the left half (including mid)");
        Console.WriteLine(" ======================================================== ");

        int[] array7 = UserArrayCreator();
        int result7 = FindMin(array7);

        Console.WriteLine($"\nInput: [{string.Join(", ", array7)}]");
        Console.WriteLine($"Output: {result7}");

        break;
    case "8":
        Console.WriteLine("Description");
        Console.WriteLine(" ======================================================== ");
        Console.WriteLine("\ngiven the array numbers after possible rotation and an integer target, return the index ");
        Console.WriteLine("of the target if it is in numbers,or -1 if it is not in numbers");
        Console.WriteLine(" ======================================================== ");

        int[] array8 = UserArrayCreator();
        int target8 = GetValidInteger("Enter Target: ");
        int result8 = SearchSortedArray(array8, target8);

        Console.WriteLine($"\nInput: [{string.Join(", ", array8)}]");
        Console.WriteLine($"Output: {result8}");
        break;
    case "9":
        Console.WriteLine("Description");
        Console.WriteLine("\n======================================================== ");
        Console.WriteLine("\ngiven an integer array numbers, return all the triplets, [numbers[i],numbers[j],numbers[k]] ");
        Console.WriteLine("\nsuch that i!-j, i!=k, and j!=k, and numbers[i] + numbers[j] + numbers[k] == 0");
        Console.WriteLine("\nnotice that the solution set must not contain duplicate triplets.");
        Console.WriteLine("\nComplexity:");
        Console.WriteLine("\nTime: O(n²) (sorting O(n log n) + nested loops O(n²))");
        Console.WriteLine("\nSpace: O(1) or O(n) depending on sorting implementation.");

        Console.WriteLine(" \n======================================================== ");

        int[] array9 = UserArrayCreator();
        IList<IList<int>> result9 = ThreeSum(array9);


        Console.WriteLine($"\nInput: [{string.Join(", ", array9)}]");

        Console.WriteLine($"\nResult");
        Console.WriteLine(" \n======================================================== ");
        if (result9.Count == 0)
        {
            Console.WriteLine("No triplets found that sum to 0.");
        }
        else
        {
            Console.WriteLine($"Found {result9.Count} unique triplet(s):\n");

            for (int i = 0; i < result9.Count; i++)
            {
                var triplet = result9[i];
                Console.WriteLine($"{i + 1}. [{string.Join(", ", triplet)}]");
                Console.WriteLine();
            }
        }
        break;

    default:
        Console.WriteLine("Invalid choice!");
        break;
}

static IList<IList<int>> ThreeSum(int[] numbers)
{
    Array.Sort(numbers);

    IList<IList<int>> result = new List<IList<int>>();

    for (int i = 0; i < numbers.Length - 2; i++)
    {
        {
            if (numbers == null || numbers.Length < 3)
                return new List<IList<int>>();

            HashSet<int> seen = new HashSet<int>();

            for (int j = i + 1; j < numbers.Length; j++)
            {
                int complete = -numbers[i] - numbers[j];

                if (seen.Contains(complete))
                {
                    result.Add(new List<int> { numbers[i], complete, numbers[j] });

                    while (j + 1 < numbers.Length && numbers[j] == numbers[j + 1])
                    {
                        j++;
                    }
                }

                seen.Add(numbers[j]);
            }
        }
    }
    return result;
}

static int SearchSortedArray(int[] numbers, int target)
{
    int left = 0;
    int right = numbers.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (numbers[mid] == target)
        {
            return mid;
        }


        // determine which side is properly sorted
        if (numbers[left] <= numbers[mid])
        {
            // Left side is sorted

            if (target >= numbers[left] && target < numbers[mid])
            {
                // Target is in the left side
                right = mid - 1;
            }
            else
            {
                // Target is in the right side
                left = mid + 1;
            }
        }
        else
        {
            // Left side is sorted
            if (target > numbers[mid] && target < numbers[right])
            {
                // target is in the sorted right side
                left = mid + 1;
            }
            else
            {
                // target is int the sorted left side
                right = mid - 1;
            }
        }
    }

    return -1;
}

static int FindMin(int[] numbers)
{
    int left = 0;
    int right = numbers.Length - 1;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        // If mid element is greater than right element,
        // minimum is in the right half
        if (numbers[mid] > numbers[right])
        {
            left = mid + 1;
        }
        // Otherwise, minimum is in the left half (including mid)
        else
        {
            right = mid;
        }
    }

    return numbers[left];
}

static int MaxProduct(int[] numbers)
{
    int maxProd = numbers[0];
    int minProd = numbers[0];
    int result = numbers[0];


    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
        {
            int temp = maxProd;
            maxProd = minProd;
            minProd = temp;
        }

        maxProd = Math.Max(numbers[i], maxProd * numbers[i]);
        minProd = Math.Min(numbers[i], minProd * numbers[i]);

        result = Math.Max(result, maxProd);
    }

    return result;
}

static int[] UserArrayCreator()
{
    Console.WriteLine("=== Array Creator ===");

    int[] numbers = CreateArrayFromUserInputs();

    Console.WriteLine($"\nArray as string: [{string.Join(", ", numbers)}]");

    return numbers;
}

static bool ContainsDuplicate(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[i] == numbers[j])
            {
                return true;
            }
        }
    }

    return false;
}

static int GetValidInteger(string message)
{
    int number = 0;
    bool validNumber = false;

    while (!validNumber)
    {
        Console.Write(message);
        string lengthInput = Console.ReadLine();

        if (int.TryParse(lengthInput, out number))
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

static int[] TwoSum(int[] numbers, int target)
{

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
            // Check if the pair sums to target
            if (numbers[i] + numbers[j] == target)
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

static int[] ProductExpectSelf(int[] numbers)
{
    int n = numbers.Length;
    int[] answer = new int[n];

    for (int i = 0; i < n; i++)
    {
        int product = 1;

        for (int j = 0; j < n; j++)
        {
            if (i != j)
            {
                product *= numbers[j];
            }
        }

        answer[i] = product;
    }

    return answer;

}

static int MaxSubArray(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        return 0;
    }

    int maxSum = int.MinValue;
    int currentSum = 0;

    foreach (int num in numbers)
    {
        currentSum += num;

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
        }

        if (currentSum < 0)
        {
            maxSum = 0;
        }
    }

    return maxSum;
}