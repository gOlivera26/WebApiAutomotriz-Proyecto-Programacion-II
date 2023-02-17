using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizBackend.Dominio;
using AutomotrizBackend.Datos;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedoresController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public VendedoresController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        [HttpGet]
        public IActionResult GetVendedores()
        {
            try
            {
                return Ok(oServicio.GetVendedores());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpPost("/vendedorFiltro")]
        public IActionResult GetVendedorFiltro(List<Parametro> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parametros");

            return Ok(oServicio.GetVendedorFiltros(lst));
        }

    }
}
