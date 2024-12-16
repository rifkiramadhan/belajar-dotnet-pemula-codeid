using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.SOLID.Practice
{

    // BAD
    //internal class VehicleISP
    //{
    //    public interface Vehicle
    //    {
    //        void startEngine();
    //        void stopEngine();
    //        void vly();
    //    }

    //    public class implements Vehicle {
    //        @override
    //        public void startEngine() { }

    //        @override
    //        public void stopEngine() { }

    //        @override
    //        public void fly() { }
    //    }

    //    public class Helicopter implements Vehicle
    //    {
    //        @override
    //        public void startEngine() { }

    //        @override
    //        public void startEngine() { }

    //        @override
    //        public void fly() { }
    //    }
    //}

    // GOOD
    //internal class VehicleISP
    //{
    //    public interface Vehicle
    //    {
    //        void startEngine();
    //        void stopEngine();
    //    }

    //    public interface Flyable
    //    {
    //        void vly();
    //    }

    //    public class implements Vehicle {
    //        @override
    //        public void startEngine() { }

    //        @override
    //        public void stopEngine() { }

    //    }

    //    public class Helicopter implements Vehicle
    //    {
    //        @override
    //            public void startEngine() { }

    //        @override
    //            public void startEngine() { }

    //        @override
    //            public void fly() { }
    //    }
    //}
}
