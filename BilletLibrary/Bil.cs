using System;

namespace BilletLibrary
{
    public class Bil : Vehicle
    {

        // Constructor
        public Bil(string nummerplade, DateTime dato):base(nummerplade,dato)
        {

        }

        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            if(Brobizz)
            {
                return (240 - (240 * 0.05m));
            }
            return 240;
        }
        
    }
}
