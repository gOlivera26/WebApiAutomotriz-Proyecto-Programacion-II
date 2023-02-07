using AutomotrizBackend.Servicios.Interfaces;
using AutomotrizBackend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizBackend.Datos;
using AutomotrizBackend.Dominio;
using Newtonsoft.Json;

namespace AutomotrizFront
{
    public partial class FrmConsultaFacturas : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public FrmConsultaFacturas()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private async void FrmConsultaFacturas_Load(object sender, EventArgs e)
        {
            
        }
      
      

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsultaFactura.Rows.Clear();
            List<Parametro> filtros = new List<Parametro>();
            Parametro fechaD = new Parametro();
            fechaD.Clave = "@fechaDesde";
            fechaD.Valor = Convert.ToDateTime(dtpFD.Value.ToShortDateString());
            Parametro fechaH = new Parametro();
            fechaH.Clave = "@fechaHasta";
            fechaH.Valor = Convert.ToDateTime(dtpFH.Value.ToShortDateString());
            filtros.Add(fechaD);
            filtros.Add(fechaH);

            string filtrosJson = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:7188/facturaFiltros";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, filtrosJson);
            List<FacConsulta> lst = JsonConvert.DeserializeObject<List<FacConsulta>>(result);
            foreach (FacConsulta item in lst)
            {
                dgvConsultaFactura.Rows.Add(new object[] { item.NroFactura, item.IdCliente.TipoCliente, item.Fecha, item.IdFormaPago.Forma, item.IdFormaEntrega.Forma });
            }

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
