using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double DistanceDriven { get; }

        void Drive(double distance);
        void Refuel(double amount);
    }
}
