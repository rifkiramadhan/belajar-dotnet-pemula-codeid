using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.OOP
{
    internal class ConstructorCar
    {
        // default / blank constructor
        public ConstructorCar()
        {

        }

        // Constructor Parameter
        public ConstructorCar(string brand, string model, string type)
        {
            Brand = brand;
            Model = model;
            Type = type;
        }

        public ConstructorCar(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public double Fuel()
        {
            return 0.0;
        }

        public double ElectricBaterai()
        {
            return 0.0;
        }

        public void StartEngine()
        {

        }
    }
}
