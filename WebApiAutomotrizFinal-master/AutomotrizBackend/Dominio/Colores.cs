using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Colores
    {
        public Colores(int id, string nombre)
        {
            IdColor = id;
            Nombre = nombre;
        }
        public Colores()
        {

        }
        public int IdColor { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
