
/*******************************************************************
 * Name: Michael Stoller
 * Date: October 25, 2026
 * Assignment: SDC220 Week 3 PA - Calculations & Unique Numbers
 *
 * Main application (program) class.
 * This application collects 10 integer values from the user and
 * stores them in an array. Unique values are stored in a List.
 *******************************************************************/

using System.Collections.Generic;

public class CalculationsUniqueNumbers
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nMichael Stoller - Week 3 PA Calculations & Unique Numbers.\n");

        // Create an array to hold 10 integers
        int[] numbersArr = new int[10];

        // Create a List to hold unique integers
        List<int> uniqueNumbers = new List<int>();

        // Get 10 integer values from the user
        for (int i = 0; i < numbersArr.Length; i++)
        {
            Console.Write("Enter integer #{0}: ", i + 1);
            int number = Convert.ToInt32(Console.ReadLine());

            // Store the number in the array
            numbersArr[i] = number;

            // Add the number to the List if it is not already there
            if (!uniqueNumbers.Contains(number))
            {
                uniqueNumbers.Add(number);
            }
        }

        // Calculate the sum and average of the array
        int arraySum = CalculateSum(numbersArr);
        double arrayAverage = (double)arraySum / numbersArr.Length;

        // Calculate the sum and average of the unique List
        int listSum = CalculateSum(uniqueNumbers);
        double listAverage = (double)listSum / uniqueNumbers.Count;

        // Display the array results
        Console.WriteLine("\nArray Results:");
        Console.WriteLine("Count of elements: {0}", numbersArr.Length);
        Console.WriteLine("Sum of elements: {0}", arraySum);
        Console.WriteLine("Average of elements: {0:F2}", arrayAverage);

        // Display the List results
        Console.WriteLine("\nUnique List Results:");
        Console.WriteLine("Count of elements: {0}", uniqueNumbers.Count);
        Console.WriteLine("Sum of elements: {0}", listSum);
        Console.WriteLine("Average of elements: {0:F2}", listAverage);
    }

    // Method to calculate the sum of integers in an array
    public static int CalculateSum(int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        return total;
    }

    // Overloaded method to calculate the sum of integers in a List
    public static int CalculateSum(List<int> numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }

        return total;
    }
}
