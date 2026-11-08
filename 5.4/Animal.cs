
/*******************************************************************
 * Name: Michael Stoller
 * Date: November 8, 2026
 * Assignment: SDC220 Week 5 PA - Inheritance & Overriding
 *
 * Animal class.
 * This is the base class that stores an animal's name and number
 * of legs.
 */

public class Animal
{
    // Class properties
    public string Name { get; set; }
    public int Legs { get; set; }

    // Constructor to set the animal's name and number of legs
    public Animal(string name, int legs)
    {
        Name = name;
        Legs = legs;
    }

    // Virtual method to print the animal's information
    public virtual void PrintAnimal()
    {
        Console.WriteLine("The Animal's name is {0} and it has {1} legs.",
            Name, Legs);
    }
}
