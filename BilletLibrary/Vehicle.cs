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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        public Vehicle(string nummerplade, DateTime dato)
        {
            if(nummerplade.Length > 7)
            {
                throw new Exception("Nummerplade må ikke være på mere end 7 tegn");
            }

            this.Nummerplade = nummerplade;
            this.Dato = dato;
            this.Brobizz = false;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nummerplade">Nummerplade på max 7 tegn</param>
        /// <param name="dato">Dato køretøjet kørte over broen</param>
        /// <param name="brobizz">Om Brobizz blev brugt til betaling</param>
        public Vehicle(string nummerplade, DateTime dato, bool brobizz)
        {
            if (nummerplade.Length > 7)
            {
                throw new Exception("Nummerplade må ikke være på mere end 7 tegn");
            }

            this.Nummerplade = nummerplade;
            this.Dato = dato;
            this.Brobizz = brobizz;
        }
    }
}
