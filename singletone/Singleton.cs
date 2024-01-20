public sealed class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    private Singleton()
    {
        // Initialization code, if any
    }

    public static Singleton Instance
    {
        get
        {
            // Using double-check locking to improve performance
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }

    // Other methods and properties can be added here
    public void SomeMethod()
    {
        Console.WriteLine("Singleton method called");
    }
}