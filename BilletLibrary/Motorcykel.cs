using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Motorcykel : Vehicle
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        public Motorcykel(string nummerplade, DateTime dato):base(nummerplade, dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        /// <param name="brobizz">Om Brobizz blev brugt til betaling</param>
        public Motorcykel(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = brobizz;
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
