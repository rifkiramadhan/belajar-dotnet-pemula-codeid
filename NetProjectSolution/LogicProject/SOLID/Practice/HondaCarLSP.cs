using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.SOLID.Practice
{
    // BAD
    //internal class HondaCarLSP
    //{
    //    public void fuel()
    //    {

    //    }

    //    public void electricBattery()
    //    {

    //    }

    //    public void startEngine()
    //    {

    //    }

    //    public class HRV extends HondaCarLSP()
    //    {
    //        @override
    //        public void elecetricBattery()
    //        {
    //            super.electricBattery();
    //        }

    //        @override
    //        public void fuel()
    //        {
    //            super.fuel();
    //        }

    //        override
    //        public void startEngine()
    //        {
    //            super.startEngine();
    //        }
    //    }

    //    public class CRVHybrid extends HondaCarLSP()
    //    {
    //        @override
    //            public void elecetricBattery()
    //    {
    //        super.electricBattery();
    //    }

    //    @override
    //            public void fuel()
    //    {
    //        super.fuel();
    //    }

    //    override
    //    public void startEngine()
    //    {
    //        super.startEngine();
    //    }
    //}

    // GOOD
    //internal class HondaCarLSP
    //{
    //    public void fuel()
    //    {

    //    }
    //    public void startEngine()
    //    {

    //    }

    //    public class HRV extends HondaCarLSP()
    //    {
    //        @override
    //        public void fuel()
    //        {
    //            super.fuel();
    //        }

    //        override
    //        public void startEngine()
    //        {
    //            super.startEngine();
    //        }
    //    }

    //    public class HondaElectric extends HondaCar
    //    {
    //        public void electricBattery();
    //    }

    //    public class CRVHybrid extends HondaElectric()
    //    {
    //        @override
    //        public void elecetricBattery()
    //        {
    //            super.electricBattery();
    //        }

    //        @override
    //        public void fuel()
    //        {
    //            super.fuel();
    //        }

    //        @override
    //        public void startEngine()
    //        {
    //            super.startEngine();
    //        }
    
    //    }
}
