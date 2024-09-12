using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal class Hubschrauber : Luftfahrzeug
    {
        public double RotorDurchmesser { get; set; }

        /// <summary>
        /// Konstrukor
        /// </summary>
        public Hubschrauber() :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hersteller"></param>
        /// <param name="baujahr"></param>
        /// <param name="rotordurchmesser"></param>
        public Hubschrauber(string hersteller, int baujahr,double rotordurchmesser) : base(hersteller, baujahr)
        {
            RotorDurchmesser = rotordurchmesser;
        }

        public override void Landen()
        {
            base.Landen();
            Console.WriteLine("Der Hubrschauber Landet");
        }

        public override void Starten()
        {
            base.Starten();
            Console.WriteLine("Der Hubschruaber Startet");
        }

        public override string ToString()
        {
            Console.WriteLine($"{base.ToString()}Der Rotordurchmesser ist {RotorDurchmesser}");
            return ToString();
        }

    }
}
