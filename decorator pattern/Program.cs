using System;

// Step 1: Define the interface
public interface IBeverage
{
    string GetDescription();
    double Cost();
}

// Step 2: Implement the concrete component
public class Espresso : IBeverage
{
    public string GetDescription()
    {
        return "Espresso";
    }

    public double Cost()
    {
        return 1.99;
    }
}

// Step 3: Create a base decorator class
public abstract class CondimentDecorator : IBeverage
{
    protected IBeverage beverage;

    public CondimentDecorator(IBeverage beverage)
    {
        this.beverage = beverage;
    }

    public abstract string GetDescription();

    public abstract double Cost();
}

// Step 4: Create concrete decorator classes
public class Milk : CondimentDecorator
{
    public Milk(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.10;
    }
}

public class Mocha : CondimentDecorator
{
    public Mocha(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.20;
    }
}

// Step 5: Client code
class Program
{
    static void Main()
    {
        // Ordering an Espresso
        IBeverage beverage = new Espresso();
        Console.WriteLine($"Description: {beverage.GetDescription()}");
        Console.WriteLine($"Cost: ${beverage.Cost()}");

        // Adding Milk to the Espresso
        IBeverage milkDecorator = new Milk(beverage);
        Console.WriteLine($"Description: {milkDecorator.GetDescription()}");
        Console.WriteLine($"Cost: ${milkDecorator.Cost()}");

        // Adding Mocha to the Milked Espresso
        IBeverage mochaDecorator = new Mocha(milkDecorator);
        Console.WriteLine($"Description: {mochaDecorator.GetDescription()}");
        Console.WriteLine($"Cost: ${mochaDecorator.Cost()}");
    }
}

