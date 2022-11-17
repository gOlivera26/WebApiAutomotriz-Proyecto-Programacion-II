using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class TipoCliente
    {
        public int IdTipoCliente { get; set; }
        public string Tipo { get; set; }
        public override string ToString()
        {
            return Tipo;
        }
    }
}
