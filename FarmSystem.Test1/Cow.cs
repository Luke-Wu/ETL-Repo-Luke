using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        /// <summary>
        /// Cow Constructor method
        /// </summary>
        /// <param name="id">The id of Cow</param>
        /// <param name="noOfLegs">Legs number of Cow</param>
        public Cow(string id, int noOfLegs) : base(id, noOfLegs,nameof(Cow))
        { 
        }

        /// <summary>
        /// Override Talk method which inherit from Animal abstract class for Cow
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        /// <summary>
        /// Cow Walk method
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        /// <summary>
        /// Implement ProduceMilk method of IMilkableAnimal interface for Cow
        /// </summary>
        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }


        /// <summary>
        /// Override Run method which inherit from Animal abstract class for Cow
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}