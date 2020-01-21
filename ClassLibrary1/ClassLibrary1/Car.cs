using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public enum EngineState { EngineOn, EngineOff}
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int maxspeed { get; set; }
        protected EngineState EngState = EngineState.EngineOn;
        public EngineState EngineState => EngState;
        public abstract void Turbo();
        public Car() { }
        public Car(string name, int maxSpd, int currSpd)
        {
            PetName = name; maxspeed = maxSpd; CurrentSpeed = currSpd; 
        }
    }
}
