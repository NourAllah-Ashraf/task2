public interface IDeliverable
{
    bool RequiresSpecialDocking { get; }

    void LoadCargo(int weight);
    void UnloadCargo(int weight);
}