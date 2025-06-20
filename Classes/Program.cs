
using System;

namespace CarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            Car myCar = new Car();

            // Set values for the properties
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;

            // Print the values to the console
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
        }
    }
}
