using System;
using System.Reflection.Emit;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] arg)
        {
            Car myCar = new Car("Oldsmobile", "Cutlas Supreme", 1986, "Silver");

            Car myNewCar = new Car();


            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color.ToUpper());
          

            Console.ReadLine();
            

        }
    }

    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color) 
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public Car()
        {
            this.Make = "Nissan";
        }

     

    }
}

