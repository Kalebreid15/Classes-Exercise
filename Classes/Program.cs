namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            
            //Set the object's properties
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2020;
            
            //Print the values on the Console
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
    }
}
