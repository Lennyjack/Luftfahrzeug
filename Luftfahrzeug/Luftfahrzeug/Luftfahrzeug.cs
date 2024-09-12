using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal abstract class Luftfahrzeug
    {
        public int Baujahr { get; set; }
        public string Hersteller { get; set; }

        public Motor Power {  get; set; } = new Motor();

        /// <summary>
        /// Konstrukor Leer
        /// </summary>
        public Luftfahrzeug()
        {
            
        }
        
        /// <summary>
        /// Konstrukor
        /// </summary>
        /// <param name="hersteller">Herstellen</param>
        /// <param name="baujahr">Baujahr</param>
        public Luftfahrzeug(string hersteller, int baujahr)
        {
            Hersteller = hersteller;
            Baujahr = baujahr;
        }

        public virtual void Landen()
        {

        }

        public virtual void Starten()
        {

        }



        public override string ToString()
        {
            Console.WriteLine($"Der Hersteller ist {Hersteller}" + $"Das Bauhjahr ist {Baujahr} \n {Power}");
            return ToString();
        }

        //public virtual string Rückgabwert()
        //{
        //    Console.WriteLine($"Der Hersteller ist {Hersteller}" + $"Das Bauhjahr ist {Baujahr}"); 
        //    return Rückgabwert();
        //}

    }
}
