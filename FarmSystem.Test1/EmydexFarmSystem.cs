using FarmSystem.Test2;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //Queue of all animals entering into the Farm
        private CustomQueue<IAnimal> animalFarm = new CustomQueue<IAnimal>();
        
        public EmydexFarmSystem()
        {
            RegisterFarmActivities();
        }

        private void RegisterFarmActivities()
        {
            animalFarm.onEnqueue += AddAnimalToFarm;
            animalFarm.onDequeue += ReleaseAnimalfromFaam;
            animalFarm.onEmpty += FarmEmpty;
        }

        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            //Console.WriteLine("Animal has entered the Emydex farm");
            var farmanimal = animal as IAnimal;

            //Push the unknown animal out of the farm
            if (farmanimal == null)
                Console.WriteLine("Unknown Animal Entered the Farm");
            else
                animalFarm.Enqueue(animal);
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            // Console.WriteLine("There are no animals in the farm");
            
            foreach(IAnimal animal in animalFarm)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (IAnimal animal in animalFarm)
            {
                var milkableAnimal = animal as IMilkableAnimal;

                if(milkableAnimal != null)
                    milkableAnimal.ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Release all the animals from the farm
            while (animalFarm.Count > 0)
            {
                animalFarm.Dequeue();
            }
        }

        private static void AddAnimalToFarm(object animal)
        {
            var farmanimal = animal as IAnimal;
            if(farmanimal != null)
                farmanimal.EnterFarm();
        }
        private static void ReleaseAnimalfromFaam(object animal)
        {
            var farmanimal = animal as IAnimal;
            if (farmanimal != null)
                farmanimal.ReleasefromFarm();
        }
        private static void FarmEmpty()
        {
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}