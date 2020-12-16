using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        /// <summary>
        /// Sheep Constructor method
        /// </summary>
        /// <param name="id">Sheep id</param>
        /// <param name="noOfLegs">Legs number of Sheep</param>
        public Sheep(string id, int noOfLegs) : base(id, noOfLegs,nameof(Sheep))
        {
        }



        /// <summary>
        /// Override Talk method which inherit from Animal abstract class for Sheep
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        /// <summary>
        ///  Override Run method which inherit from Animal abstract class for Sheep
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }

}