class Program
{
    static void Main()
    {
        // Accessing the singleton instance
        EagerLoadedSingleton singletonInstance = EagerLoadedSingleton.Instance;

        // Calling a method on the singleton instance
        singletonInstance.SomeMethod();

        // Attempting to create another instance (will still get the same instance)
        EagerLoadedSingleton anotherInstance = EagerLoadedSingleton.Instance;

        // Checking if both instances are the same
        Console.WriteLine($"Are both instances the same? {ReferenceEquals(singletonInstance, anotherInstance)}");
    }
}