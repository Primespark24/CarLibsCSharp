using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    class SportsCar : Car
    {
        public SportsCar() { }
        public SportsCar(string name, int maxSpd, int currSpd) : base (name, maxSpd, currSpd) { }
        public override void Turbo()
        {
            Console.WriteLine("Ramming Speed!");
        }
    }

    class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSpd, int currSpd) : base(name, maxSpd, currSpd) { }
        public override void Turbo()
        {
            EngState = EngineState.EngineOff;
            Console.WriteLine("Engine Exploded!");
        }
    }
}
