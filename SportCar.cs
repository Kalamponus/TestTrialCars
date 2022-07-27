using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial
{
    public class SportCar : Automobile
    {
        private int passengerCount { get; set; }

        public SportCar(double avgFuelConsumption, double fuelTankCapacity, double speed, int passengerCount) : base(avgFuelConsumption, fuelTankCapacity, speed)
        {
            this.passengerCount = passengerCount;
        }

        public override double TravelDistanceLeft(double fuelLeft)
        {
            return fuelLeft / (avgFuelConsumption / 100);
        }

        public override void DisplayPowerReserveInfo()
        {
            double powerReserve;
            if (passengerCount < 2 && passengerCount > -1) //В расчёт брал, что у спорткаров, обычно, только один пассажир, кроме водителя
            {
                powerReserve = TravelDistanceLeft(fuelTankCapacity);
                if (passengerCount > 0)
                {
                    powerReserve -= powerReserve / 100 * 6;
                }
                Console.WriteLine("Запас хода: " + powerReserve);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные: неверное число пассажиров");
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
