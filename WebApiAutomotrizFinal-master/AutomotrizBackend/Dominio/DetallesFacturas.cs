using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class DetallesFacturas
    {
        public DetallesFacturas(double pre, int cant, Vehiculo v)
        {

            PrecioUnitario = pre;
            Cantidad = cant;
            Vehiculo = v;

        }
        public DetallesFacturas()
        {

        }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public Vehiculo Vehiculo { get; set; }


        public double CalcularSubtotalVehiculo()
        {
            return Vehiculo.Precio * Cantidad;
        }


    }
}
