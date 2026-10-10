
/*******************************************************************
 * Name: Michael Stoller
 * Date: October 10, 2026
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Employee class.
 * This class defines an employee using first name, last name,
 * and monthly salary properties. It includes a constructor
 * and a method to update the monthly salary.
 * Salaries must be greater than or equal to $1000.
 *******************************************************************/

public class Employee
{
    // Employee properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double MonthlySalary { get; private set; }

    // Constructor to initialize employee information
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;

        // Validate monthly salary
        if (monthlySalary >= 1000)
        {
            MonthlySalary = monthlySalary;
        }
    }

    // Update employee monthly salary
    public void UpdateSalary(double newSalary)
    {
        // Validate new monthly salary
        if (newSalary >= 1000)
        {
            MonthlySalary = newSalary;
        }
    }
}
