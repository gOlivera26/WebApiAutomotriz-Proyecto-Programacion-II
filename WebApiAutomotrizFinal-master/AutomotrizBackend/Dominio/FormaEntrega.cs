using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class FormaEntrega
    {
        public int IdFormaEntrega { get; set; }
        public string Forma { get; set; }
        public override string ToString()
        {
            return Forma;
        }
    }
}
