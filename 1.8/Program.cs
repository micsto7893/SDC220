
/*******************************************************************
 * Name: Michael Stoller
 * Date: October 10, 2026
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Main application class.
 * This program demonstrates the use of classes, constructors,
 * methods, and properties by creating two employee objects.
 * It displays employee information, updates names and salaries,
 * and displays the updated information.
 *******************************************************************/

public class Program
{
    static void Main(string[] args)
    {
        // Display program header
        Console.WriteLine("Michael Stoller - Week 1 PA Classes.\n");

        // Create two employee objects
        Employee employee1 = new Employee("John", "Smith", 3500);
        Employee employee2 = new Employee("Jane", "Doe", 800);

        // Display original employee information
        Console.WriteLine("Original Employee Information\n");

        Console.WriteLine("Employee 1: {0} {1}", 
            employee1.FirstName, employee1.LastName);
        Console.WriteLine("Monthly Salary: {0:C}\n", 
            employee1.MonthlySalary);

        Console.WriteLine("Employee 2: {0} {1}", 
            employee2.FirstName, employee2.LastName);
        Console.WriteLine("Monthly Salary: {0:C}\n", 
            employee2.MonthlySalary);

        // Update employee names
        employee1.LastName = "Johnson";
        employee2.FirstName = "Janet";

        // Update employee monthly salaries
        employee1.UpdateSalary(4000);
        employee2.UpdateSalary(2500);

        // Display updated employee information
        Console.WriteLine("Updated Employee Information\n");

        Console.WriteLine("Employee 1: {0} {1}", 
            employee1.FirstName, employee1.LastName);
        Console.WriteLine("Monthly Salary: {0:C}\n", 
            employee1.MonthlySalary);

        Console.WriteLine("Employee 2: {0} {1}", 
            employee2.FirstName, employee2.LastName);
        Console.WriteLine("Monthly Salary: {0:C}", 
            employee2.MonthlySalary);
    }
}
