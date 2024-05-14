using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_47
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Diet { get; set; }

        //Abstract methods (stubbed out methods)
        public abstract void Move();

        //Non stubbed out methods
        //using the virtual keyword allows you to have some default functionality in your method
        public virtual void Breathe()
        {
            Console.WriteLine("Animal is breathing!");
        }
    }
}
