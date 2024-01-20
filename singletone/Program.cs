class Program
{
    static void Main()
    {
        // Accessing the singleton instance
        Singleton singletonInstance = Singleton.Instance;

        // Calling a method on the singleton instance
        singletonInstance.SomeMethod();

        // Attempting to create another instance (will still get the same instance)
        Singleton anotherInstance = Singleton.Instance;

        // Checking if both instances are the same
        Console.WriteLine($"Are both instances the same? {ReferenceEquals(singletonInstance, anotherInstance)}");
    }
}
