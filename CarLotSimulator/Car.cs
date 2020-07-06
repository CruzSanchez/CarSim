using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        // DONE Create a seperate class file called Car 
        // DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        // DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        // DONE The methods should take one string parameter: the respective noise property

        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public Car()
        {
            //Default Constructor
            CarLot._numberOfCars++;
        }

        public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;
            CarLot._numberOfCars++;
        }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }
    }
}
