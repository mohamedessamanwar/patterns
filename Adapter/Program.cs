using System;

// Existing Legacy System
class LegacySystem
{
    public void PerformLegacyOperation(string legacyData)
    {
        Console.WriteLine($"Legacy operation is performed with data: {legacyData}");
    }
}

// New System Interface
interface NewSystemInterface
{
    void PerformNewOperation(DataObject newData);
}

// DataObject representing data in the new system
class DataObject
{
    public string NewData { get; set; }
}

// Adapter class to integrate LegacySystem with NewSystemInterface
class LegacySystemAdapter : NewSystemInterface
{
    private LegacySystem legacySystem;

    public LegacySystemAdapter(LegacySystem legacySystem)
    {
        this.legacySystem = legacySystem;
    }

    public void PerformNewOperation(DataObject newData)
    {
        // Map the data from the new system to the legacy system
        string legacyData = MapData(newData);

        // Call the legacy operation with the mapped data
        legacySystem.PerformLegacyOperation(legacyData);
    }

    // Logic to map data from new system to legacy system
    private string MapData(DataObject newData)
    {
        // Simple mapping logic for demonstration purposes
        return $"Mapped: {newData.NewData}";
    }
}

// Client code in the new system
class NewSystemClient
{
    static void Main()
    {
        // Create an instance of LegacySystem
        LegacySystem legacySystem = new LegacySystem();

        // Create an instance of LegacySystemAdapter, adapting LegacySystem to NewSystemInterface
        NewSystemInterface adapter = new LegacySystemAdapter(legacySystem);

        // Create an instance of DataObject in the new system
        DataObject newData = new DataObject
        {
            NewData = "New System Data"
        };

        // Call the PerformNewOperation method on the NewSystemInterface with the new data
        adapter.PerformNewOperation(newData);
    }
}
