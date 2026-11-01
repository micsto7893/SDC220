
/*******************************************************************
 * Name: Michael Stoller
 * Date: November 1, 2026
 * Assignment: SDC220 Week 4 PA - Account Balance Calculations
 *
 * This application demonstrates the use of user-defined exceptions
 * by allowing the user to enter an account starting balance and
 * process credits or debits. 
 *******************************************************************/

public class AccountBalanceCalculations
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "Michael Stoller - Week 4 PA Account Balance Calculations.");

        decimal balance = 0;
        bool validBalance = false;

        // Ask the user to enter a starting balance
        do
        {
            try
            {
                Console.Write("\nPlease enter the starting balance: ");
                string? input = Console.ReadLine();
                balance = Convert.ToDecimal(input);

                // Prevent a negative starting balance
                if (balance < 0)
                {
                    throw new Exception(
                        "Starting balance cannot be negative.");
                }

                validBalance = true;
                Console.WriteLine("Starting balance: {0:C}", balance);
            }
            catch (FormatException e)
            {
                // Print exception information
                Console.WriteLine("\nException: {0}", e);
                Console.WriteLine(
                    "Invalid input. Please enter a numeric value.");
            }
            catch (Exception e)
            {
                // Print user-defined exception information
                Console.WriteLine("\nUser-Defined Exception: {0}", e);
                Console.WriteLine(e.Message);
            }

        } while (!validBalance);

        // Continue processing transactions until zero is entered
        bool cont = true;

        do
        {
            try
            {
                Console.WriteLine("\nCurrent balance: {0:C}", balance);
                Console.Write(
                    "Enter a credit (+) or debit (-), or 0 to quit: ");

                string? input = Console.ReadLine();
                decimal amount = Convert.ToDecimal(input);

                // Exit the program if zero is entered
                if (amount == 0)
                {
                    cont = false;
                    Console.WriteLine(
                        "\nFinal account balance: {0:C}", balance);
                    Console.WriteLine("Program ended.");
                    continue;
                }

                // Check if a debit would cause a negative balance
                if (balance + amount < 0)
                {
                    throw new Exception(
                        "Transaction of " + amount.ToString("C") +
                        " would cause the account balance to go negative.");
                }

                // Update the account balance
                balance += amount;

                // Print the updated balance
                Console.WriteLine(
                    "Updated account balance: {0:C}", balance);
            }
            catch (FormatException e)
            {
                // Print the exception information
                Console.WriteLine("\nException: {0}", e);

                // Print an error message
                Console.WriteLine(
                    "Invalid input. You must enter a number. Please try again.");
            }
            catch (Exception e)
            {
                // Print the user-defined exception information
                Console.WriteLine("\nUser-Defined Exception: {0}", e);
                Console.WriteLine(e.Message);
                Console.WriteLine(
                    "Transaction canceled. Balance remains: {0:C}", balance);
            }

        } while (cont);
    }
}
