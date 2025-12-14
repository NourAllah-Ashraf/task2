public class DeliveryTruck : IDeliverable
{
    private string truckName;
    private int currentLoadWeight;
    private int maxLoadCapacity;

    public DeliveryTruck(string truckName, int maxLoadCapacity)
    {
        this.truckName = truckName;
        this.maxLoadCapacity = maxLoadCapacity;
        this.currentLoadWeight = 0;
    }

    public string TruckName
    {
        get { return truckName; }
    }

    public int CurrentLoadWeight
    {
        get { return currentLoadWeight; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Warning: Load cannot be negative. Setting load to 0.");
                currentLoadWeight = 0;
            }
            else if (value > maxLoadCapacity)
            {
                Console.WriteLine("Warning: Load exceeds max capacity! Setting load to max capacity.");
                currentLoadWeight = maxLoadCapacity;
            }
            else
            {
                currentLoadWeight = value;
            }
        }
    }

    public virtual void StartEngine()
    {
        Console.WriteLine("DeliveryTruck engine started.");
    }


    public bool RequiresSpecialDocking
    {
        get { return false; }
    }

    public void LoadCargo(int weight)
    {
        Console.WriteLine($"Attempting to load {weight} kg onto {TruckName}...");
        CurrentLoadWeight = CurrentLoadWeight + weight;  // uses validation
        Console.WriteLine($"Current load after loading: {CurrentLoadWeight} kg");
    }

    public void UnloadCargo(int weight)
    {
        Console.WriteLine($"Attempting to unload {weight} kg from {TruckName}...");
        CurrentLoadWeight = CurrentLoadWeight - weight;  // uses validation
        Console.WriteLine($"Current load after unloading: {CurrentLoadWeight} kg");
    }
}
