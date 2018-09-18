using System;

namespace BilletLibrary
{
    public class Bil : Vehicle
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        public Bil(string nummerplade, DateTime dato):base(nummerplade,dato)
        {
            Nummerplade = nummerplade;
            Dato = dato;
            Brobizz = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        /// <param name="brobizz">Om Brobizz blev brugt til betaling</param>
        public Bil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
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
            if(Brobizz)
            {
                return (240 - (240 * 0.05m));
            }
            return 240;
        }
        
    }
}
