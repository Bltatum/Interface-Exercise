namespace Interface
{
    public interface IGasVehicle
    {
        void RefuelTank();

        int CurrentFuelPercentage { get; set; }
    }
}