using System;
using System.Collections;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {

        private readonly Queue<Animal> animalStock;

        //FarmEmptyHandler delegate
        public delegate void FarmEmptyHandler(Object sender, FarmEmptyEventArgs e);
        
        //FarmEmpty event
        public event FarmEmptyHandler FarmEmpty;

        /// <summary>
        /// Constructor method
        /// </summary>
        public EmydexFarmSystem()
        {
            animalStock = new Queue<Animal>();
        }


        //TEST 1
        public void Enter(Animal animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            //add animal into animalStock queue, queue is first in first Out collection
            animalStock.Enqueue(animal);
            Console.WriteLine($"{animal.Name} has entered the farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (animalStock.Count > 0)
            {

                foreach (var animal in animalStock)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            if (animalStock.Count > 0)
            {
              

                foreach (var animal in animalStock)
                {
                    //judge whether the animal implement IMilkableAnimal interface
                    if (animal is IMilkableAnimal)
                    {
                        IMilkableAnimal milkAnimal = animal as IMilkableAnimal;
                        milkAnimal.ProduceMilk();
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }
         
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            //Release all animals from animalstock queue
            while (animalStock.Count > 0)
            {
                var animal = animalStock.Dequeue();
                Console.WriteLine($"{animal.Name} has left the farm");
                
            }

            //Invoke FarmEmpty event once all the animals are released
            if (animalStock.Count == 0)
            {
                FarmEmpty(this, new FarmEmptyEventArgs("Emydex Farm is now empty"));
            }
         
        }
    }
}