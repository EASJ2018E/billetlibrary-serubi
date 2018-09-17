using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract klasse som alle køretøjer nedarver fra
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Abstract metode der angiver, hvad det koster for køretøjet at køre over broen.
        /// Override denne metode i klassen som nedarver.
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Navnet på køretøjstypen.
        /// Default er "Bil".
        /// </summary>
        /// <returns></returns>
        public virtual string Køretøj()
        {
            return "Bil";
        }

        /// <summary>
        /// Nummerpladen på køretøjet
        /// </summary>
        public string Nummerplade { get; set; }

        /// <summary>
        /// Dato køretøjet kørte over broen
        /// </summary>
        public DateTime Dato { get; set; }

        /// <summary>
        /// Er Brobizz brugt til betaling?
        /// </summary>
        public bool Brobizz { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Vehicle()
        {

        }

        public Vehicle(string nummplade, DateTime dato)
        {
            if(nummplade.Length > 7)
            {
                throw new Exception("Nummerplade må ikke være på mere end 7 tegn");
            }

            this.Nummerplade = nummplade;
            this.Dato = dato;
            this.Brobizz = false;
        }

        public Vehicle(string nummplade, DateTime dato, bool brobizz)
        {
            if (nummplade.Length > 7)
            {
                throw new Exception("Nummerplade må ikke være på mere end 7 tegn");
            }

            this.Nummerplade = nummplade;
            this.Dato = dato;
            this.Brobizz = brobizz;
        }
    }
}
