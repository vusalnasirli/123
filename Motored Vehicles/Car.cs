using System;

namespace Motored_Vehicles
{
    public class Car : MotoredVehicle
    {
        public Car(string model, string make, DateTime productionYear) : base(model, make, productionYear)
        {
        }
        public double FuelTankSize { get; set; }
        public bool IsOn { get; set; }

        public void TurnOn()
        {
            this.IsOn = true;
        }
        public void TurnOff()
        {

            this.IsOn = false;
        }

        public string Go(double Distance)
        {
            if (IsOn==false)
            {
                return "Maşın gedə bilməz";
            }
            if (FuelAmount>=Distance* FuelUsedPerKm)
            {
                return $"{Distance}km məsafə qət edildi";
            }
            return "Kifayət qədər yanacaq yoxdur";
        }
        public override string GetDetailedInfo()
        {

            return $"Model - {Model}\nMake - {Make},\nProduction Year - {ProductionYear}\nMotor Size - {MotorSize}\nColor - {Color}\nHorsePower - {HorsePower}";
        }
    }
}
