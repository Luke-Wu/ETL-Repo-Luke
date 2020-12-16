using System;

namespace FarmSystem.Test1
{
    public class Horse : Animal
    {
        /// <summary>
        /// Horse Constructor method
        /// </summary>
        /// <param name="id">Horse id</param>
        /// <param name="noOfLegs">Legs number of Horse</param>
        public Horse(string id, int noOfLegs) : base(id, noOfLegs,nameof(Horse))
        {
        }


        /// <summary>
        /// Override Talk method which inherit from Animal abstract class for Horse
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Horse says Neigh!");
        }

        /// <summary>
        ///  Override Run method which inherit from Animal abstract class for Horse
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Horse is running");
        }
        
    }
}