using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Autopartes
    {
        public Autopartes()
        {
            Marca = new Marcas();
            Modelo = new Modelos();
            IdAutoparte = 0;
            Descripcion = "";
            Precio = 0;
            Stock = 0;
            StockMinimo = 0;
        }
        public int IdAutoparte { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public Marcas Marca { get; set; }
        public Modelos Modelo { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
