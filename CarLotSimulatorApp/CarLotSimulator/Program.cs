using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot = new CarLot();

            var honda = new Car();
            honda.Year = 2001;
            honda.Make = "Honda";
            honda.Model = "Accord";
            honda.EngineNoise = "Vroom";
            honda.HonkNoise = "beep!";
            honda.IsDriveable = true;

            honda.MakeEngineNoise("vroom");
            honda.MakeHonkNoise("honk");

            carLot.Cars.Add(honda);

            var volkswagen = new Car
            {
                Year = 2005,
                Make = "Volkswagen",
                Model = "Jetta",
                EngineNoise = "vroom",
                HonkNoise = "honk",
                IsDriveable = true
            };

            volkswagen.MakeEngineNoise("vroom");
            volkswagen.MakeHonkNoise("honk");
            carLot.Cars.Add(volkswagen);

            var dodge = new Car()
            {
                Year = 2010,
                Make = "Dodge",
                Model = "Charger",
                EngineNoise = "vrooom",
                HonkNoise = "honk",
                IsDriveable = true
            };

            dodge.MakeEngineNoise("vroom");
            dodge.MakeHonkNoise("honk");
            carLot.Cars.Add(dodge);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in carLot.Cars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
            }
        }
    }
}
