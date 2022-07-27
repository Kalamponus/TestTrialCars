using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial
{
    public class Truck : Automobile
    {
        private float cargoWeight { get; set; }
        private float maxCargoWeight{ get; set; }

        public Truck(double avgFuelConsumption, double fuelTankCapacity, double speed, float cargoWeight, float maxCargoWeight) : base(avgFuelConsumption, fuelTankCapacity, speed)
        {
            this.cargoWeight = cargoWeight;
            this.maxCargoWeight = maxCargoWeight;
        }

        public override double TravelDistanceLeft(double fuelLeft)
        {
            return fuelLeft / (avgFuelConsumption / 100);
        }

        public override void DisplayPowerReserveInfo()
        {
            double powerReserve;
            if (cargoWeight > -1 && cargoWeight <= maxCargoWeight)
            {
                powerReserve = TravelDistanceLeft(fuelTankCapacity);
                if (cargoWeight > 0)
                {
                    powerReserve -= (powerReserve / 100 * (cargoWeight / 50)); //Если 200 кг уменьшают запас хода на 4%, то 50 кг уменьшает его на 1%, поэтому я рассчитываю, насколько уменьшает груз запас хода, даже если там менее 200 кг
                }
                Console.WriteLine("Запас хода: " + powerReserve);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные: вес груза больше допустимого");
            }
        }

        public override void DisplayTimeToTravelDistance(double fuel, double distance)
        {
            double time;
            if (distance <= TravelDistanceLeft(fuel))
            {
                time = distance / speed;
                Console.WriteLine("Время, за которое автомобиль пройдёт введёное расстояние: " + time);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные: дистанция больше допустимой");
            }
        }
    }
}
