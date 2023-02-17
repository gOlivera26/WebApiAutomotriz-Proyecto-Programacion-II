using AutomotrizBackend.Datos;
using AutomotrizBackend.Datos.Implementaciones;
using AutomotrizBackend.Datos.Interfaces;
using AutomotrizBackend.Dominio;
using AutomotrizBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Servicios.Implementaciones
{
    public class Servicio : IServicio
    {
        private IFacturasDao oDao;
        public Servicio()
        {
            oDao = new FacturasDao();
        }

        public bool CrearAutoparte(Autopartes a)
        {
            return oDao.CrearAutoparte(a);
        }


        public bool CrearVehiculo(Vehiculo v)
        {
            return oDao.CrearVehiculo(v);
        }

        public List<Autopartes> GetAutopartes()
        {
            return oDao.CargarAutopartes();
        }

        public List<Cliente> GetClientes()
        {
            return oDao.CargarClientes();
        }

        public List<Colores> GetColores()
        {
            return oDao.GetColores();
        }

        public List<FormaEntrega> GetFormaEntrega()
        {
            return oDao.GetFormaEntrega();
        }

        public List<FormasPago> GetFormaPago()
        {
            return oDao.CargarFormaPago();
        }

        public List<Marcas> GetMarcas()
        {
            return oDao.GetMarcas();
        }

        public List<Modelos> GetModelos()
        {
            return oDao.GetModelos();
        }

        public List<TipoCliente> GetTipoCliente()
        {
            return oDao.GetTipo();
        }

        public List<Vehiculo> GetVehiculos()
        {
            return oDao.GetVehiculos();
        }

        public List<Vendedor> GetVendedores()
        {
            return oDao.CargarVendedores();
        }

        public bool CrearCliente(Cliente c)
        {
            return oDao.CrearCliente(c);
        }

        public bool PostFacturacionVehiculo(Facturas f)
        {
            return oDao.AltaVehiculo(f);
        }

        public List<Vehiculo> GetVehiculosFiltros(List<Parametro> criterios)
        {
            return oDao.CargarVehiculosFiltros(criterios);
        }

        public List<Autopartes> GetAutopartesFiltros(List<Parametro> criterios)
        {
            return oDao.CargarAutopartesFiltros(criterios);
        }

        public List<FacConsulta> GetFactura(List<Parametro> criterios)
        {
            return oDao.CargarFacturas(criterios);
        }

        public List<Cliente> GetClientesFiltros(List<Parametro> criterios)
        {
            return oDao.CargarClientesFiltro(criterios);
        }

        public List<Vendedor> GetVendedorFiltros(List<Parametro> criterios)
        {
            return oDao.CargarVendedoresFiltro(criterios);
        }
    }
}
