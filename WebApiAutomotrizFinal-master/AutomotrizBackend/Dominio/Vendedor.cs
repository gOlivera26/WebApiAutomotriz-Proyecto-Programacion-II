using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Vendedor
    {

        public int IdVendedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Email { get; set; }
        public double NroTel { get; set; }
        public int NroDoc { get; set; }
        public string Barrio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
