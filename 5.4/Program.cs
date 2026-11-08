
/*******************************************************************
 * Name: Michael Stoller
 * Date: November 8, 2026
 * Assignment: SDC220 Week 5 PA - Inheritance & Overriding
 *
 * Main application class.
 * This program demonstrates inheritance and method overriding.
 */

public class Program
{
    static void Main(string[] args)
    {
        // Print header
        Console.WriteLine("\nMichael Stoller - Week 5 PA - Inheritance & Overriding\n");

        // Create an instance of each class
        Animal animal = new Animal("Nora", 4);
        Cat cat = new Cat("Kwazii", 4, "meow");

        // Print the original properties
        animal.PrintAnimal();
        cat.PrintAnimal();

        // Update the properties of each object
        animal.Name = "Flipper";
        animal.Legs = 0;

        cat.Name = "Garfield";
        cat.Legs = 4;
        cat.Sound = "I need lasagna";

        // Print the updated properties
        animal.PrintAnimal();
        cat.PrintAnimal();
    }
}
