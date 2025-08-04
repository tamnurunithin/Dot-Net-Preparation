using System;

class Vehicle
{
    class Car
    {
        public string brand;
        public int speed;

        public void Drive()
        {
            Console.WriteLine($"{brand} is driving at {speed} km/h.");
        }
    }

    static void Main(string[] args) // 'Main' must be capitalized and should be static
    {
        Car c = new Car();
        c.brand = "Benz";  // typo corrected from "bench"
        c.speed = 100;
        c.Drive();         // missing Drive method call
    }
}
