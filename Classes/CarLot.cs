using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
       // As a Field
        public List<Car> carList = new List<Car>();

        // With the property in there ("CarList")

        public List<Car> CarList { get; set; } = new List<Car>();

    }
}
