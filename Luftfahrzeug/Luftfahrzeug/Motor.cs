using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal class Motor
    {
        private int _gewicht;

        public int Gewicht
        {
            get { return _gewicht; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException($"{value} darf nicht unter 0 sein.");
                _gewicht = value;
            }
        }

        public string Hersteller { get; set; }
        public float Leistung { get; set; }
        public string Name { get; set; }

        public Motor()
        {
            Hersteller = string.Empty;
            Leistung = 0.0f;
            Name = string.Empty;
            Gewicht = 0;

        }

        public Motor(string name, string hersteller)
            : this()
        {
            Name = name;
            Hersteller = hersteller;
        }

        public override string ToString()
        {
            Console.WriteLine($"Der Hersteller ist {Hersteller}" + 
                $"Die Leistung ist {Leistung}" + 
                $" Das Gewicht ist {Gewicht}" + 
                $"Der Name ist {Name}");
            return ToString();
        }


    }
}
