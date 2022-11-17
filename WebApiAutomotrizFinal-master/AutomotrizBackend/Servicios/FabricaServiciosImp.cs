using AutomotrizBackend.Servicios.Implementaciones;
using AutomotrizBackend.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Servicios
{
    public class FabricaServiciosImp : FabricaServicios
    {
        public override IServicio CrearServicio()
        {
            return new Servicio();
        }
    }
}
