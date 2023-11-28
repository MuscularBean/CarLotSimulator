using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() { CarLot.NumberOfCars++; }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDrivable { get; set; }

        public void MakeEngineNoise() { Console.WriteLine(EngineNoise); }
        public void MakeHonkNoise() {  Console.WriteLine(HonkNoise); }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
            CarLot.NumberOfCars++;
        }

        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }

    }
}
