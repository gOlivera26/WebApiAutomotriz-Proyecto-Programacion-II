using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomotrizBackend.Dominio;

namespace WebApiAutomotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturacionController : ControllerBase
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public FacturacionController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        [HttpPost("/AltaVehiculo")]
        public IActionResult PostVehiculo(Facturas f)
        {
            try
            {
                return Ok(oServicio.PostFacturacionVehiculo(f));
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }


    }
}
