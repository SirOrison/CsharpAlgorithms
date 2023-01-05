using ConsoleApp1;
using System;
using System.Collections;
using System.Reflection.Emit;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] arg)
        {
           
           
            Console.ReadLine();
        }     
    }

    class Car
    {
        public string Make { get; set; }
        public string  Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    /* List<Car> myCar = new List<Car>()
            {
                new Car {VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year= 2009},
                new Car {VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year= 2010},
                new Car {VIN="C3", Make="BMW", Model="745li", StickerPrice=75000, Year= 2008},
                new Car {VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year= 2008},
                new Car {VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year= 2010}
            };*/

    //LINQ query
    /*var bmws = from car in myCar
               where car.Make == "BMW"
               && car.Year == 2010
               select car;*/

    /*var orderedCars = from car in myCar
                     orderby car.Year descending
                     select car;*/


    //LINQ method

    //var bmws = myCar.Where( car => car.Make == "BMW" && car.Year == 2010);

    //var orderedCars = myCar.OrderByDescending(car => car.Year);


   /* var FirstBmw = myCar.OrderByDescending(car => car.Year).First(car => car.Make == "BMW");


    Console.WriteLine(FirstBmw.VIN);
*/
            /*foreach (var bm in orderedCars) {

                Console.WriteLine("{0} {1} {2}", bm.Year, bm.Model, bm.VIN);
            }*/

    
}

