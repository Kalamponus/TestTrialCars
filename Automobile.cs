using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial
{
    public abstract class Automobile
    {
        public double avgFuelConsumption { get; set; }
        public double fuelTankCapacity { get; set; }
        public double speed { get; set; }
        
        public Automobile(double avgFuelConsumption, double fuelTankCapacity, double speed) //Я не понял, зачем нужен параметр типа автомобиля, если мы создаем классы под каждый вид и этот параметр нигде не используется, поэтому убрал его
        {
            this.avgFuelConsumption = avgFuelConsumption;
            this.fuelTankCapacity = fuelTankCapacity;
            this.speed = speed;
        }

        /// <summary>
        /// Возвращает сколько автомобиль может проехать при введёном топливе
        /// </summary>
        /// <param name="fuelLeft">Сколько осталось топлива</param>
        /// <returns></returns>
        public abstract double TravelDistanceLeft(double fuelLeft);

        /// <summary>
        /// Выводит запас хода автомобиля
        /// </summary>
        public abstract void DisplayPowerReserveInfo();

        /// <summary>
        /// Выводит время, за которое автомобиль проедет дистанцию
        /// </summary>
        /// <param name="fuel">Сколько топлива в автомобиле</param>
        /// <param name="distance">Расстояние, которое нужно проехать</param>
        /// <returns></returns>                
        public abstract void DisplayTimeToTravelDistance(double fuel, double distance);
    }
}
