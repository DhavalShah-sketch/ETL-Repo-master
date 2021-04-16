using System;

namespace FarmSystem.Test1
{
    public class Hen : BaseAnimal
    {
        public Hen()
        {
            NumberOfLegs = 2;
        }
        public Hen(int NoOfLegs) : base(NoOfLegs)
        {
        }
        public override void Walk()
        {
            Console.WriteLine("Hen is walking");
        }
        public override void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }

    }
}