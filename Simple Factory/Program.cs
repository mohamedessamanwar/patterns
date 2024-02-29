using System;

// Product interface
public interface IAnimal
{
    void Speak();
}

// Concrete Products
public class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

// Simple Factory
public class AnimalFactory
{
    public IAnimal CreateAnimal(string animalType)
    {
        switch (animalType)
        {
            case "Dog":
                return new Dog();
            case "Cat":
                return new Cat();
            default:
                throw new ArgumentException("Invalid animal type");
        }
    }
}

// Client code
class Program
{
    static void Main()
    {
        AnimalFactory factory = new AnimalFactory();

        // Creating a Dog
        IAnimal dog = factory.CreateAnimal("Dog");
        dog.Speak();  // Output: Woof!

        // Creating a Cat
        IAnimal cat = factory.CreateAnimal("Cat");
        cat.Speak();  // Output: Meow!
    }
}

