using System;

// Product: Represents the complex object to be constructed
public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
    }
}

// Builder interface: Specifies the construction steps
public interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}

// Concrete Builder: Implements the construction steps
public class MargheritaPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    public void BuildDough()
    {
        _pizza.Dough = "Thin Crust";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "Tomato";
    }

    public void BuildTopping()
    {
        _pizza.Topping = "Cheese";
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}

// Director: Manages the construction process using a builder
public class PizzaDirector
{
    private IPizzaBuilder _pizzaBuilder;

    public PizzaDirector(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }

    public void ConstructPizza()
    {
        _pizzaBuilder.BuildDough();
        _pizzaBuilder.BuildSauce();
        _pizzaBuilder.BuildTopping();
    }
}

// Client code
class Program
{
    static void Main()
    {
        // Using the Builder pattern to construct a Margherita Pizza
        var margheritaPizzaBuilder = new MargheritaPizzaBuilder();
        var pizzaDirector = new PizzaDirector(margheritaPizzaBuilder);

        pizzaDirector.ConstructPizza();
        Pizza margheritaPizza = margheritaPizzaBuilder.GetPizza();
        margheritaPizza.Display();
    }
}

