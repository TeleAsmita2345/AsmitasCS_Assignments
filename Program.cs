using System;

namespace Program4
{
 ////   Create an interface vehicle and classes like bicycle, car, bike etc, having common functionalities and put all the common functionalities in the interface. Classes
 ////like Bicycle, Bike, car etc implement all these functionalities in their own class in their own way.
   interface Vehicle
    {
        void Run();
    }
    class Bicycle : Vehicle
    {
        public void Run()
        {
            Console.WriteLine("The Bicycle is run");
        }
    }
    class Bike : Vehicle
    {
        public void Run()
        {
            Console.WriteLine("The Bike is Run");
        }
    }
    class Car :Vehicle
    {
        public void Run()
        {
            Console.WriteLine("The Car is Run");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bi = new Bicycle();
            bi.Run();
            Bike b = new Bike();
            b.Run();
            Car c = new Car();
            c.Run();
            
        }
    }
}
