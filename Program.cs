using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrial
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            LightAuto lightAuto = new LightAuto(5, 60, 110, 4);
            Console.WriteLine("Сколько может проехать легковой автомобиль с {0}л топлива: {1}", 40, lightAuto.TravelDistanceLeft(40));
            lightAuto.DisplayTimeToTravelDistance(40, 300); //Не зналю, какая скорость имеется ввиду, поэтому вводил максимальную
            lightAuto.DisplayPowerReserveInfo();

            Truck truck = new Truck(20, 400, 100, 600, 1000);
            Console.WriteLine("Сколько может проехать легковой автомобиль с {0}л топлива: {1}", 40, truck.TravelDistanceLeft(200));
            truck.DisplayTimeToTravelDistance(200, 800);
            truck.DisplayPowerReserveInfo();

            SportCar sportCar = new SportCar(11, 121, 410, 1);
            Console.WriteLine("Сколько может проехать легковой автомобиль с {0}л топлива: {1}", 33, sportCar.TravelDistanceLeft(33));
            sportCar.DisplayTimeToTravelDistance(66, 300);
            sportCar.DisplayPowerReserveInfo();

            Console.ReadLine();
        }
    }
}
