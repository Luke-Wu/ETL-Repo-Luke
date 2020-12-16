using System;

namespace FarmSystem.Test1
{
    public class Hen : Animal
    {
        /// <summary>
        /// Hen Constructor method
        /// </summary>
        /// <param name="id">Hen id</param>
        /// <param name="noOfLegs">Legs number of Hen</param>
        public Hen(string id, int noOfLegs) : base(id, noOfLegs,nameof(Hen))
        {
        }

        /// <summary>
        /// Override Talk method which inherit from Animal abstract class for Hen
        /// </summary>
        public override void Talk()
        {
            Console.WriteLine("Hen says CLUCKAAAAAWWWWK!");
        }

        /// <summary>
        ///  Override Run method which inherit from Animal abstract class for Hen
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}