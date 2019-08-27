
using System;
using System.Linq;
using System.Collections.Generic;
class Sample
{
    static void Main()
    {
        Owner ownerMax = new Owner() { Country = "Usa", Name = "Max" };
        Owner ownerPetro = new Owner() { Country = "Ukraine", Name = "Petro" };
        Owner ownerSuzy = new Owner() { Country = "Belarus", Name = "Suzy" };
        List<Car> myCars = new List<Car>() {
                                                      new Car()
                                                          {
                                                              VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009,
                                                              Owner = ownerSuzy,
                                                          },
                                                      new Car()
                                                          {
                                                              VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010,
                                                              Owner = ownerSuzy
                                                          },
                                                      new Car()
                                                          {
                                                              VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008,
                                                              Owner = ownerMax
                                                          },
                                                      new Car()
                                                          {
                                                              VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008,
                                                              Owner = ownerPetro
                                                          },
                                                      new Car()
                                                          {
                                                              VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010,
                                                              Owner = ownerMax
                                                          }
                                                  };
        //   var NotFordCarsExtension = myCars.Where( Car car => return car.Make != "Ford"; ).ToArray();
        bool anyNewCars = myCars.Any(p => p.Year > 2010);
        myCars.ForEach(car => car.StickerPrice -= 3000);
        double TotalPrice = myCars.Sum(p => p.StickerPrice);
        Console.WriteLine(anyNewCars);
        //List<Car> myCars = new List<Car>();
        /*foreach(Car myCar in myCars)
        {
            foreach(Owner lastOwner in )
        }
        */
        Console.ReadKey();
    }
    class Car
    {
        private Owner owner;
        public Car()
        {
            AllOwners = new List<Owner>();
        }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double StickerPrice { get; set; }

        public Owner Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
                AllOwners.Add(value);
            }
        }

        public List<Owner> AllOwners { get; set; }
    }

    // var allbutnowford for
    class Owner
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

}