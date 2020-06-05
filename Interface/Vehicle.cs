using System;

namespace Interface
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("This vehicle goes Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle turned {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("This vehicle stopped!");
        }
    }



    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; } = 100;
        public int CurrentChargePercentage { get; set; } = 50;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("MEEEEEEEEEEE");
        }

        public Tesla(double batteryKWh, int currentChargePercentage)
        {
            BatteryKWh = batteryKWh;
            CurrentChargePercentage = currentChargePercentage;
        }


    }


    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 50;
        public int CurrentFuelPercentage { get; set; } = 50;

        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public void RefuelTank()
        {
            FuelCapacity = 100;
        }

        public Cessna(double fuel, int fuelPerc)
        {
            FuelCapacity = fuel;
            CurrentFuelPercentage = CurrentFuelPercentage;
        }
    }

    public class Zero : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; } = 25;
        public int CurrentChargePercentage { get; set; } = 50;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public Zero(double batteryKWh, int currentChargePercentage)
        {
            BatteryKWh = batteryKWh;
            CurrentChargePercentage = currentChargePercentage;
        }


        public override void Drive()
        {
            Console.WriteLine("SHHHHHHHHHH!");
        }
    }

    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; } = 45;
        public int CurrentFuelPercentage { get; set; } = 60;

        public override void Drive()
        {
            Console.WriteLine("BLAAAAAAAHHHHH");
        }

        public void RefuelTank()
        {
            CurrentFuelPercentage = 100;
        }
        public Ram(double fuel, int fuelPerc)
        {
            FuelCapacity = fuel;
            CurrentFuelPercentage = CurrentFuelPercentage;
        }
    }




}
