using System;

namespace FarmSystem.Test1
{
    public class Sheep: BaseAnimal
    {
        public Sheep()
        {
            NumberOfLegs = 4;
        }
        public Sheep(int NoOfLegs) : base(NoOfLegs)
        {
        }
        public override void Walk()
        {
            Console.WriteLine("Sheep is walking");

        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}