using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal class Flugzeug : Luftfahrzeug
    {
        public double Spannweite { get; set; }

        public Flugzeug() : base()
        {
            
        }

        /// <summary>
        /// Flugzeug Konstrukot, erbt von Luftfahrtzeug
        /// </summary>
        /// <param name="hersteller">Hersteller</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="spannweite">Spannweie</param>
        public Flugzeug(string hersteller, int baujahr, double spannweite) : base(hersteller, baujahr)
        {
            Spannweite = spannweite;
        }

        public override void Landen()
        {
            base.Landen();
            Console.WriteLine("Das Flugzeug Landet.");
        }

        public override void Starten()
        {
            base.Starten();
            Console.WriteLine("Das Flugzeug startet.");
        }

        public override string ToString()
        {
            Console.WriteLine($"{ base.ToString()} Die Spannweite beträg {Spannweite}");
            return ToString();
        }

    }
}
