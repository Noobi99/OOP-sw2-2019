using System;
using System.Collections.Generic;

namespace Lektion05
{
    
    // Et objekt laves sammenligenligt med Interface IComparable
    public class Car : IComparable 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int CompareTo(object obj)
        {
            // Hvis de er ens returneres 0
            return Price.CompareTo(((Car)obj).Price);
        }

        public override string ToString()
        {
            return $"{Make}, {Model}, {Price}";
        }
    }
    
//b. Implement the interface IComparer<Car> to sort cars by Make, then by Model and lastly by Price
    // bruges til dependency injection
    class CompareCarByMakeModelPrice : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            int make = x.Make.CompareTo(y.Make);
            if (make == 0)
            {
                int model = x.Model.CompareTo(y.Model);
                if (model == 0)
                {
                    int price = x.Price.CompareTo(y.Price);
                    if (price == 0)
                    {
                        return price;
                    }   
                }
                return model;
            }
            
            return make;
        }   
    }

// c. Implement the interface IComparer<Car> to sort cars by Model, and then by Price in
    // reverse order.
    class CompareCarByModelReversePrice : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            int modelComp = x.Model.CompareTo(y.Model);
            
            if (modelComp == 0)
            {
                return -(x.Price.CompareTo(y.Price));    
            }

            return -(modelComp);

        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Make="Skoda", Model = "Fabia", Price = 50000},
                new Car(){Make="Skoda", Model = "Octavia", Price = 60000},
                new Car(){Make="Ford", Model = "Mondeo", Price = 23000}, 
                new Car(){Make="Nissan", Model = "Qaushi", Price = 12003},
                new Car(){Make="Ferria", Model = "Italia 458", Price = 1000000},
                new Car() {Make = "Lamborghini", Model = "Aventador", Price = 1000000}
            };

            
            cars.Sort();
            foreach (var car in cars)
            {
                Console.WriteLine(car);    
            }
           

             /*
             //cars.Sort(new CompareCarByMakeModelPrice());
             cars.Sort(new CompareCarByModelReversePrice());
             
             foreach (var car in cars)
             {
                 Console.WriteLine(car.Make + ", " + car.Model + ", " + car.Price);
             }
             */
             
             /*
             Car[] carsarr = new Car[]
             {
                 new Car(){Make="Skoda", Model = "Octavia", Price = 60000},
                 new Car(){Make="Ferrari", Model = "Italia", Price = 23000}, 
                 new Car(){Make="Nissan", Model = "Qashqai", Price = 12003}   
             };

             Array.Sort(carsarr, new CompareCarByMake());
  */
        }
    }
}