using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.OOP
{
    internal class InheritanceCar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public double Fuel() { return 0.0; }
        public double ElectricBaterial()
        {
            return 0.0;
        }
        public void StartEngine()
        { }
    }

    internal class SUV : InheritanceCar
    {
        public bool HasSkidPlate()
        {
            return true;
        }

        public bool HasRoofRack()
        {
            return true;
        }
    }

    internal class MVP : InheritanceCar
    {
        public int LCD { get; set; }
        public bool HasSlideDoor()
        {
            return true;
        }
    }
}
