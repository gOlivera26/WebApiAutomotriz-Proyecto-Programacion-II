using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class Facturas
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int IdFormaEntrega { get; set; }
        public int IdFormaPago { get; set; }
        public int IdCliente { get; set; }
        public int idVendedor { get; set; }
  
        public List<DetallesFacturas> Detalles { get; set; }
        public Facturas()
        {
            Detalles = new List<DetallesFacturas>();
       
        }
        public Facturas(int NroF, DateTime f, int IdFEntrega, int IdFPago, int IdClient, int IdVend)
        {
            NroFactura = NroF;
            Fecha = f;
            IdFormaEntrega = IdFEntrega;
            IdFormaPago = IdFPago;
            IdCliente = IdClient;
            idVendedor = IdVend;
        }

        public void AgregarDetalle(DetallesFacturas detalle)
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
        public double CalcularTotalVehiculos()
        {
            double total = 0;
            foreach (DetallesFacturas item in Detalles)
            {
                total += item.CalcularSubtotalVehiculo();
            }
            return total;
        }


    }
}
