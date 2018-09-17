using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Motorcykel
    {
        // Instance fields
        private string _nummerplade;
        private DateTime _dato;

        // Constructor
        public Motorcykel()
        {

        }

        // Methods

        /// <summary>
        /// Get price for vehicle
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Get vehicle type name
        /// </summary>
        /// <returns></returns>
        public string Køretøj()
        {
            return "MC";
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
