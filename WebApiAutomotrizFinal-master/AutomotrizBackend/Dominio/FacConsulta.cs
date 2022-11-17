using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Dominio
{
    public class FacConsulta
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public FormaEntrega IdFormaEntrega { get; set; }
        public FormasPago IdFormaPago { get; set; }
        public Cliente IdCliente { get; set; }
        public int idVendedor { get; set; }

        public List<DetallesFacturas> Detalles { get; set; }
        public FacConsulta()
        {
            Detalles = new List<DetallesFacturas>();
            IdFormaEntrega = new FormaEntrega();
            IdFormaPago = new FormasPago();
            IdCliente = new Cliente();

        }
        public FacConsulta(int NroF, DateTime f, int IdFEntrega, int IdFPago, int IdClient, int IdVend)
        {
           
        
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
