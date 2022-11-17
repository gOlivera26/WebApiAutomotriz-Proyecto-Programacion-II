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
    public class AutopartesController : ControllerBase
    {

        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public AutopartesController()
        {
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }
        [HttpPost("/crearAutoparte")]
        public IActionResult PostAutoparte(Autopartes a)
        {
            if(a != null)
            {
                bool result = oServicio.CrearAutoparte(a);
                return Ok(result);
            }
            return BadRequest("Parametro autoparte requerido");
        }
        [HttpGet]
        public IActionResult GetAutopartes()
        {
            try
            {
                return Ok(oServicio.GetAutopartes());
            }
            catch (Exception)
            {
                return BadRequest("No se pudo completar la accion");
            }
        }
        [HttpPost]
        public IActionResult GetAutopartesFiltros(List<Parametro> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parametros");

            return Ok(oServicio.GetAutopartesFiltros(lst));

        }
    }
}
