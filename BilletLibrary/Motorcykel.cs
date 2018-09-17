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

        public Motorcykel(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            if (Brobizz)
            {
                return (125 - (125 * 0.05m));
            }
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
