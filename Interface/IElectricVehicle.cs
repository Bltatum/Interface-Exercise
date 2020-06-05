namespace Interface
{
    public interface IElectricVehicle
    {
        void ChargeBattery();

        int CurrentChargePercentage { get; set; }
    }
}