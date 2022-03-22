using System;

namespace Motored_Vehicles
{
    public class MotoredVehicle
    {
        public MotoredVehicle()
        {
            Model = "Default Model";
            Make = "Default User";
            ProductionYear = new DateTime(2022);
        }
        public MotoredVehicle(string model, string make, DateTime productionYear)
        {
            this.Model = model;
            this.Make = make;
            this.ProductionYear = productionYear;
        }
        public string Model { get; set; }
        public string Make { get; set; }
        public DateTime ProductionYear { get; set; }
        public int MotorSize { get; set; }
        public double FuelAmount { get; set; }
        public double FuelUsedPerKm { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public int PassangerCount { get; set; }

        public string GetInfo() {

            return $"Model - {Model}\nMake - {Make}\nProduction Year - {ProductionYear}\nMotor Size - {MotorSize} ";
        }

        public virtual string GetDetailedInfo()
        {

            return $"Model - {Model}\nMake - {Make},\nProduction Year - {ProductionYear}\nMotor Size - {MotorSize}\nColor - {Color}\nHorsePower - {HorsePower}";
        }
    }
}
