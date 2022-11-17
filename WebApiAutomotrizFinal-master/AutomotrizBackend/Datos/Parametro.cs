using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Datos
{
    public class Parametro
    {
        public string Clave { get; set; }
        public object Valor { get; set; }

        public Parametro(string clave, object valor)
        {
            Clave = clave;
            Valor = valor;
        }
        public Parametro()
        {
            Clave = "";
            Valor = 0;
        }
    }
}
