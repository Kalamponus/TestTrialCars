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

        public abstract double TravelDistanceLeft(double fuelLeft);

        public abstract void DisplayPowerReserveInfo();

        public abstract void DisplayTimeToTravelDistance(double fuel, double distance);
    }
}
