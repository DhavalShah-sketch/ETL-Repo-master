using System;

namespace FarmSystem.Test1
{
    public class Horse: BaseAnimal
    {
        public Horse()
        {
            NumberOfLegs = 4;
        }
        public Horse(int NoOfLegs) : base(NoOfLegs)
        {
        }
        public override void Walk()
        {
            Console.WriteLine("Horse is walking");
        }

        public override void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}