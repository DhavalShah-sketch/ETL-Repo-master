using FarmSystem.Test1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private List<BaseAnimal> animalsInFarm = new List<BaseAnimal>();
        public int AnimalsCurrentlyInFarm()
        {
            return animalsInFarm.Count();
        }
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine($"{animal.GetType().Name} has entered the Emydex farm");
            animalsInFarm.Add((BaseAnimal)animal);
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (var animal in animalsInFarm)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            var milkableAnimals = animalsInFarm.Where(a => a is IMilkableAnimal);
            foreach (var animal in milkableAnimals)
            {
                Console.WriteLine($"{animal.GetType().Name} has milked!");
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           //Console.WriteLine("There are still animals in the farm, farm is not free, releasing them now!");
            while (animalsInFarm.Count > 0)
            {
                Console.WriteLine($"{animalsInFarm[0].GetType().Name} has left the farm");
                animalsInFarm.RemoveAt(0); // FIFO
            }
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}