using System;

public sealed class EagerLoadedSingleton
{
    // Static variable that holds the single instance of the class
    private static readonly EagerLoadedSingleton instance = new EagerLoadedSingleton();

    // Private constructor to prevent instantiation of the class from outside
    private EagerLoadedSingleton()
    {
        // Initialization code, if any
    }

    // Public property to access the single instance
    public static EagerLoadedSingleton Instance
    {
        get { return instance; }
    }

    // Other methods and properties can be added here
    public void SomeMethod()
    {
        Console.WriteLine("Eager-loaded Singleton method called");
    }
}