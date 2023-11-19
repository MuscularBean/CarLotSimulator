using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLot = new CarLot();
            



            Console.WriteLine("Car Number One");
            Car myCar1 = new Car()
            {
                Year = 2023,
                Make = "Toyota",
                Model = "Camry",
                HonkNoise = "Loud",
                EngineNoise = "Low/Medium",
            };

            myLot.Cars.Add(myCar1);

            Console.WriteLine($"Year: {myCar1.Year}\nMake: {myCar1.Make}\nModel: {myCar1.Model}");

            myCar1.MakeEngineNoise();
            myCar1.MakeHonkNoise();

            Console.WriteLine("----------------");
            Console.WriteLine("Car Number Two");
            Car myCar2 = new Car();
            myCar2.Year = 2020;
            myCar2.Make = "Ford";
            myCar2.Model = "Focus";
            myCar2.HonkNoise = "Low/Medium";
            myCar2.EngineNoise = "Low";

            myLot.Cars.Add (myCar2);

            Console.WriteLine($"Year : {myCar2.Year}\nMake: {myCar2.Make}\nModel: {myCar2.Model}");
            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise();

            Console.WriteLine("----------------");

            Console.WriteLine("Car Number Three");

            var myCar3 = new Car (1969,"Chevy","Camaro");
            Console.WriteLine($"Year: {myCar3.Year}\nMake: {myCar3.Make}\nModel: {myCar3.Model}");

            myLot.Cars.Add(myCar3 );

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("--------------");

            foreach (var car in myLot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}Make: {car.Make}Model: {car.Model}");
            }
        }
    }
}
