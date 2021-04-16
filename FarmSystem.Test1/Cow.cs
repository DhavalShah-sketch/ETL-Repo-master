using System;
using FarmSystem.Test1.Interfaces;

namespace FarmSystem.Test1
{
    public class Cow : BaseAnimal, IMilkableAnimal
    {
        public Cow()
        {
            NumberOfLegs = 4; // default
        }
        public Cow(int NoOfLegs): base(NoOfLegs)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public override void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }
        public override void ProduceMilk()
        {
            Console.WriteLine("Cow is producing milk.");
        }

    }
}