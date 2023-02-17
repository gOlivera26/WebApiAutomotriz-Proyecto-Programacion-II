using AutomotrizBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Datos.Interfaces
{
    public interface IFacturasDao
    {
        List<FormaEntrega> GetFormaEntrega();
        List<Marcas> GetMarcas();
        List<Modelos> GetModelos();
        List<Colores> GetColores();
        List<TipoCliente> GetTipo();
        List<Cliente> CargarClientes();
        List<FormasPago> CargarFormaPago();
        List<Vendedor> CargarVendedores();
        List<FacConsulta> CargarFacturas(List<Parametro>criterios);
        List<Autopartes> CargarAutopartesFiltros(List<Parametro> criterios);
        List<Autopartes> CargarAutopartes();
        List<Vehiculo> CargarVehiculosFiltros(List<Parametro> criterios);
        List<Cliente> CargarClientesFiltro(List<Parametro>criterios);
        List<Vendedor> CargarVendedoresFiltro(List<Parametro> criterios);
        bool CrearCliente(Cliente c);
        bool AltaVehiculo(Facturas f);
        bool CrearVehiculo(Vehiculo v);
        bool CrearAutoparte(Autopartes a);
        List<Vehiculo> GetVehiculos();
    }
}
