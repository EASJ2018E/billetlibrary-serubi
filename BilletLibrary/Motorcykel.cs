using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Motorcykel : Vehicle
    {

        // Constructor
        public Motorcykel(string nummerplade, DateTime dato):base(nummerplade, dato)
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Get vehicle type name
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }

    }
}
