using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// Create abstract class Animal for different animal instance to inherit from
    /// </summary>
    public abstract class Animal
    {
        #region private fields
        private string _id;
        private string _name;
        private int _noOfLegs;
        #endregion


        /// <summary>
        /// Animal Constructor method
        /// </summary>
        /// <param name="animalId">Animal Id</param>
        /// <param name="legsNumber">Animal legs number</param>
        /// <param name="animalName">Animal name</param>
        public Animal(string animalId,int legsNumber,string animalName)
        {
            Id = animalId;
            NoOfLegs = legsNumber;
            Name = animalName;
        }

        #region public properties
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }
        #endregion


        #region public abstract method
        public abstract void Talk();

        public abstract void Run();
        #endregion



    }
}
