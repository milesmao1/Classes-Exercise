using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
        }

        // custom contructor below
        public Car (int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            int Year = year;
            string Make = make;
            string Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make {get; set; }
        public string Model { get; set; }   
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }


        public void MakeEngineNoise (string engineNoise) 
        { 
            Console.WriteLine ($"{engineNoise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }
}
