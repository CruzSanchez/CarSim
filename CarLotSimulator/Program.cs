using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carLot = new CarLot();
                       
            //TODO

            //Now that the Car class is created we can instanciate 3 new cars
            Console.WriteLine(CarLot._numberOfCars);

            //The long way
            Car car1 = new Car();
            Console.WriteLine(CarLot._numberOfCars);

            //Adding a new car to the carList
            carLot.CarList.Add(car1);
            
            car1.Year = "2000";
            car1.Make = "Toyota";
            car1.Model = "Celica";
            car1.EngineNoise = "Vrrrrrroooooom";
            car1.HonkNoise = "Honk Honk";
            car1.IsDrivable = false;

            //Object Initializer Syntax
            var car2 = new Car()
            {
                Year = "2016",
                Make = "BMW",
                Model = "328i",
                EngineNoise = "Toot Toot",
                HonkNoise = "Beep Beep",
                IsDrivable = true
            };
            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(car2);

            //Parameterized Constructor
            Car car3 = new Car("2015", "Mercedes", "G Wagon", "prrrrrrr", "durk durk", true);
            Console.WriteLine(CarLot._numberOfCars);
            carLot.CarList.Add(car3);

            // DONE Set the properties for each of the cars
            // DONE Call each of the methods for each car

            //Console.WriteLine("Car 1");
            //car1.MakeEngineNoise(car1.EngineNoise);
            //car1.MakeHonkNoise(car1.HonkNoise);
            //Console.WriteLine();

            //Console.WriteLine("Car 2");
            //car2.MakeEngineNoise(car2.EngineNoise);
            //car2.MakeHonkNoise(car2.HonkNoise);
            //Console.WriteLine();

            //Console.WriteLine("Car 3");
            //car3.MakeEngineNoise(car3.EngineNoise);
            //car3.MakeHonkNoise(car3.HonkNoise);

            foreach (Car car in carLot.CarList)
            {
                Console.WriteLine($"Year = {car.Year} Make = {car.Make} Model = {car.Model}");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            // DONE Create a CarLot class
            // DONE It should have at least one property: a List of cars
            // DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
