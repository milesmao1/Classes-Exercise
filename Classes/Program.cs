using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    public class Car
    {
        //Constructor
        public Car() 
        { 
        }
       
        
        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        
        
        
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mercedes Benz";
            myCar.Model = "S580";
            myCar.Year = 2023;

                       
            var carList = new List<Car>() { myCar};

            foreach (var vehicle in carList)
            {

                Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
            }
        }
    }
}
