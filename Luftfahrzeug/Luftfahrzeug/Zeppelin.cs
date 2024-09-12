using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal class Zeppelin : Luftfahrzeug
    {
        public double Gasvolumen { get; set; }


        /// <summary>
        /// Leerer Konstrukor
        /// </summary>
        public Zeppelin()
            :this(string.Empty, 0, 0.0)
        { 

        }

        /// <summary>
        /// Konstruko erbt von Basis Konstrukor mithilfe on :base() 
        /// </summary>
        /// <param name="hersteller">Hersteller</param>
        /// <param name="baujahr">Baujahr</param>
        /// <param name="gasvolumen">Gasvolumen</param>
        public Zeppelin(string hersteller, int baujahr, double gasvolumen) :base(hersteller, baujahr) 
        {
            Gasvolumen = gasvolumen;
        }


        public override void Landen()
        {
            base.Landen();
            Console.WriteLine("Der Zeppelin Landet");
        }

        public override void Starten()
        {
            base.Starten();
            Console.WriteLine("Der Zeppelin Startet");
        }

        public override string ToString()
        {
            Console.WriteLine($"{base.ToString()} \t Das Gasvolumen ist {Gasvolumen}");
            return ToString();
        }
    }
}
