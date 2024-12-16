using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject.OOP
{
    public class OverridingAnimal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic Animal Sound!");
        }
    }

    public class Dog : OverridingAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Cat : OverridingAnimal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
