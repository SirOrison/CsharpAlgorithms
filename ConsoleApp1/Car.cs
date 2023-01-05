using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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

//ArrayLists are dynamically sized
// cool features sorting, remove items

/* ArrayList myArrayList = new ArrayList();
 myArrayList.Add(car1);
 myArrayList.Add(car2);
 myArrayList.Add(b1);

 foreach (Car car in myArrayList)
 {
     Console.WriteLine(car.Make);
 }
*/
/* List<Car> myList = new List<Car>();
 myList.Add(car1);
 myList.Add(car2);

 foreach (Car car in myList)
 {
     Console.WriteLine(car.Make);
 }*/

//Dictionary<Tkey, TValue>

/* Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

 myDictionary.Add(car1.VIN, car1);
 myDictionary.Add(car2.VIN, car2);*/