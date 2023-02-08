using AutomotrizBackend.Datos;
using AutomotrizBackend.Dominio;
using AutomotrizBackend.Servicios;
using AutomotrizBackend.Servicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront
{
    public partial class frmClientes : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public frmClientes()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private async void frmClientes_Load(object sender, EventArgs e)
        {
            await cargarTipoCliente();
        }

        private async Task cargarTipoCliente()
        {
            string url = "https://localhost:7188/tipoCliente";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<TipoCliente>lst = JsonConvert.DeserializeObject<List<TipoCliente>>(data);
            cboTipo.DataSource = lst;
            cboTipo.ValueMember = "IdTipoCliente";
            cboTipo.DisplayMember = "Tipo";
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();

            string url = "https://localhost:7188/api/Cliente";

            var result = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(result);
            foreach(Cliente item in lst)
            {
                dgvClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Barrio, item.Calle, item.Altura, item.NroDoc, item.NroTel });
            }

        }
    }
}
