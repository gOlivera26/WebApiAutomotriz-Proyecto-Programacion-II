using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizBackend.Dominio;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public ClienteController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        [HttpGet("/tipoCliente")]
        public IActionResult GetTipoCliente()
        {
            try
            {
                return Ok(oServicio.GetTipoCliente());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpGet]
        public IActionResult GetClientes()
        {
            try
            {
                return Ok(oServicio.GetClientes());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }

        [HttpPost("/CrearCliente")]
        public IActionResult PostCliente(Cliente c)
        {
            if (c != null)
            {
                bool result = oServicio.CrearCliente(c);
                return Ok(result);
            }
            return BadRequest("Parametro requerido");

        }

    }
}

