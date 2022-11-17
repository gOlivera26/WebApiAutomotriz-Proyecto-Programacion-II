using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Vehiculo
    {
        public Vehiculo()
        {
            Marca = new Marcas();
            Modelo = new Modelos();
            Color = new Colores();
            IdVehiculo = 0;
            Precio = 0;
            Stock = 0;
            Descripcion = "";
        }
        public int IdVehiculo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public Marcas Marca { get; set; }
        public Modelos Modelo { get; set; }
        public Colores Color { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
