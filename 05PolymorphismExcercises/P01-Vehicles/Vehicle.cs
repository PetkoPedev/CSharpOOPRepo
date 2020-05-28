using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double distanceDriven;

        public Vehicle(double fuelQuantity, double fuelConsumption, double distanceDriven)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.DistanceDriven = distanceDriven;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            private set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            private set { this.fuelConsumption = value; }
        }

        public double DistanceDriven
        {
            get { return this.distanceDriven; }
            private set { this.distanceDriven = value; }
        }

        public void Drive(double distance)
        {
            throw new NotImplementedException();
        }

        public void Refuel(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
