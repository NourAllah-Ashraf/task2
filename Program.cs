
//
// ===================================
// DERIVED CLASS: RefrigeratedTruck
// ===================================
using System.Dynamic;

public class RefrigeratedTruck : DeliveryTruck
{
    public RefrigeratedTruck(string truckName, int maxLoadCapacity)
        : base(truckName, maxLoadCapacity)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("RefrigeratedTruck engine started. Cooling system activated.");
    }
}


//
// ===================================
// DERIVED CLASS: LuxuryCourierVan
// ===================================
public class LuxuryCourierVan : DeliveryTruck
{
    private bool hasPremiumInterior;

    public LuxuryCourierVan(string vanName, int maxLoadCapacity, bool hasPremiumInterior)
        : base(vanName, maxLoadCapacity)
    {
        this.hasPremiumInterior = hasPremiumInterior;
    }

    public void ActivateClimateControl()
    {
        if (hasPremiumInterior)
        {
            Console.WriteLine("Climate control activated: Premium interior mode engaged.");
        }
        else
        {
            Console.WriteLine("Climate control activated: Standard comfort mode.");
        }
    }

    public override void StartEngine()
    {
        Console.WriteLine("LuxuryCourierVan engine started quietly. Premium driving experience engaged.");
    }

//     public override bool RequiresSpecialDocking
//     {
//         get { return false;}
// }


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Delivery Vehicle Demonstration ===\n");

        // Base class instance
        DeliveryTruck basicTruck = new DeliveryTruck("Standard Truck", 5000);
        basicTruck.StartEngine();
        basicTruck.LoadCargo(2000);
        basicTruck.UnloadCargo(500);
        Console.WriteLine($"Requires special docking? {basicTruck.RequiresSpecialDocking}\n");

        // Refrigerated truck instance
        RefrigeratedTruck coldTruck = new RefrigeratedTruck("Cold Hauler", 3000);
        coldTruck.StartEngine();
        coldTruck.LoadCargo(1000);
        Console.WriteLine($"Requires special docking? {coldTruck.RequiresSpecialDocking}\n");

        // Luxury Courier Van instance
        LuxuryCourierVan luxuryVan = new LuxuryCourierVan("Elite Courier", 1500, true);
        luxuryVan.StartEngine();
        luxuryVan.ActivateClimateControl();
        luxuryVan.LoadCargo(600);
        Console.WriteLine($"Requires special docking? {luxuryVan.RequiresSpecialDocking}\n");

        Console.WriteLine("=== End of Demo ===");
    }
}}
