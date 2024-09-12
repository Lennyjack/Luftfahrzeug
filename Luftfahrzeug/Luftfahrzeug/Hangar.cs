using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftfahrzeug
{
    internal class Hangar
    {
        public string Name { get; set; }
        public string Ort { get; set; }

        public List<Luftfahrzeug> Luftfahrzeug { get; set; }

        public Hangar()
            :this(string.Empty, string.Empty)
        {

            
        }

        public Hangar(string name, string ort)
        {
            Name = name;
            Ort = ort;
            Luftfahrzeug = new List<Luftfahrzeug>();
        }

    }
}
