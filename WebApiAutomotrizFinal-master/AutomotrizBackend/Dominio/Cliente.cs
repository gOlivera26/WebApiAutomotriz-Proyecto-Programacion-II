using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Cliente
    {
        public Cliente()
        {
            TipoCliente = new TipoCliente();
            IdCliente = 0;
            Nombre = "";
            Apellido = "";
            Calle = "";
            Altura = 0;
            Email = "";
            NroDoc = 0;
            NroTel = 0;
            Barrio = "";
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Email { get; set; }
        public int NroTel { get; set; }
        public int NroDoc { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public string Barrio { get; set; }

        public override string ToString()
        {
            return Apellido;
        }
    }
}
