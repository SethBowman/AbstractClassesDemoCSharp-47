using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_47
{
    public class Dog : Animal
    {        

        //When you implement an abstract method in a derived (child) class, you have to use the override keyword
        //That gives the stubbed out method it's functionality
        public override void Move()
        {
            Console.WriteLine("Dog runs!");
        }

        public override void Breathe()
        {
            Console.WriteLine("Dog is breathing!");
        }
    }
}
