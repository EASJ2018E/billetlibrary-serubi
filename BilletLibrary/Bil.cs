using System;

namespace BilletLibrary
{
    public class Bil
    {
        // Instance fields
        private string _nummerplade;
        private DateTime _dato;

        // Constructor
        public Bil()
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Get vehicle type name
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "Bil";
        }

        // Backing fields
        public string Nummberplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
    }
}
