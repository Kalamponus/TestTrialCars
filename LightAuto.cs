using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial
{
    public class LightAuto : Automobile
    {
        private int passengerCount { get; set; }

        public LightAuto(double avgFuelConsumption, double fuelTankCapacity, double speed, int passengerCount) : base(avgFuelConsumption, fuelTankCapacity, speed)
        {
            this.passengerCount = passengerCount;
        }
        
        public override double TravelDistanceLeft(double fuelLeft) //Решил не разделять на полный и неполный бак, поэтому вводится просто топливо
        {
            return fuelLeft / (avgFuelConsumption / 100); 
        }

        public override void DisplayPowerReserveInfo() //Водителя за пассажира не считал и не включал в уравнение, но если нужно, то можно легко переделать
        {
            double powerReserve;
            if (passengerCount < 5 && passengerCount > -1)
            {
                powerReserve = TravelDistanceLeft(fuelTankCapacity);
                if(passengerCount > 0)
                {
                    powerReserve -= (powerReserve / 100 * 6) * passengerCount;
                }
                Console.WriteLine("Запас хода: " + powerReserve);
            }
            else
            {
                Console.WriteLine("Введены некорректные данные: неверное число пассажиров");
            }
        }

        public override void DisplayTimeToTravelDistance(double fuel, double distance) //Не уверен, зачем тут требуется топливо, поэтому сделал проверку, хватит ли его на поездку без заправки
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
