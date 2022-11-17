using AutomotrizBackend.Dominio;
using AutomotrizBackend.Servicios;
using AutomotrizBackend.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormasController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public FormasController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        [HttpGet("/FormaEntregas")]
        public IActionResult GetFormaEntrega()
        {
            try
            {
                return Ok(oServicio.GetFormaEntrega());
            }
            catch (Exception)
            {

                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpGet("/FormaPago")]
        public IActionResult GetFormaPago()
        {
            try
            {
                return Ok(oServicio.GetFormaPago());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }


    
    }
}
