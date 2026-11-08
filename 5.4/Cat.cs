
/*******************************************************************
 * Name: Michael Stoller
 * Date: November 8, 2026
 * Assignment: SDC220 Week 5 PA - Inheritance & Overriding
 *
 * Cat class.
 * This class inherits from the Animal class and adds a Sound
 * property.
 */

public class Cat : Animal
{
    // Class property
    public string Sound { get; set; }

    // Constructor uses the base class constructor
    public Cat(string name, int legs, string sound) : base(name, legs)
    {
        Sound = sound;
    }

    // Override the Animal class PrintAnimal method
    public override void PrintAnimal()
    {
        Console.WriteLine("The Cat's name is {0}, it has {1} legs and is making a {2} sound.\n",
            Name, Legs, Sound);
    }
}
