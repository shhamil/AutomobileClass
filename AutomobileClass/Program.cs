using System;

namespace AutomobileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            truck.LoadCapacityKg = 3000;
            truck.Speed = 90;
            truck.TankSize = 200;
            truck.TypeTM = "Truck";
            truck.AvgFuel = 30;
            Console.WriteLine(truck.TankRange(34));
            Console.WriteLine(truck.Range(truck.TankRange(34), 2982));

            PassengerCar passengerCar = new PassengerCar();
            passengerCar.passengers = 4;
            passengerCar.Speed = 150;
            passengerCar.TankSize = 50;
            passengerCar.TypeTM = "Passenger Car";
            passengerCar.AvgFuel = 7;
            Console.WriteLine(passengerCar.TankRange(20));
            Console.WriteLine(passengerCar.Range(passengerCar.TankRange(20), passengerCar.passengers));
        }
    }
}
