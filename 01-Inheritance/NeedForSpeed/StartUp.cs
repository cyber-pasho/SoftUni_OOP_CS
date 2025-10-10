using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            
        }
    }
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsumption = DefaultFuelConsumption;
        }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption { get; set; }
        public virtual void Drive(double kilometers)
        {
            double neededFuel = kilometers * FuelConsumption;

            if (Fuel >= neededFuel)
            {
                Fuel -= neededFuel;
            }
            else
            {
                // Not enough fuel — simulate realistic message
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
    }
    public class Motorcycle
        : Vehicle
    {
        public Motorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }
    }

    public class RaceMotorcycle
        : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8.0;
            FuelConsumption = DefaultFuelConsumption;
        }
    }

    public class CrossMotorcycle
        : Motorcycle
    {
        public CrossMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
    }
    public class Car
        : Vehicle
    {
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3.0;
            FuelConsumption = DefaultFuelConsumption;
        }
    }

    public class SportCar
        : Car
    {
        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
            FuelConsumption = DefaultFuelConsumption;
        }
    }

    public class FamilyCar
        : Car
    {
        public FamilyCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {

        }
    }
}
