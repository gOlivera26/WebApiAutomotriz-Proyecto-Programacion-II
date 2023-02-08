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
            List<TipoCliente> lst = JsonConvert.DeserializeObject<List<TipoCliente>>(data);
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
            foreach (Cliente item in lst)
            {
                dgvClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Barrio, item.Calle, item.Altura, item.NroDoc, item.NroTel });
            }

        }

        private async void btnConsultarFiltro_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                dgvClientes.Rows.Clear();

                List<Parametro> filtros = new List<Parametro>();
                Parametro nombre = new Parametro();
                nombre.Clave = "@nombre";
                nombre.Valor = Convert.ToString(txtNombre.Text);
                Parametro apellido = new Parametro();
                apellido.Clave = "@apellido";
                apellido.Valor = Convert.ToString(txtApellido.Text);
                Parametro dni = new Parametro();
                dni.Valor = Convert.ToInt32(txtDni.Text);
                dni.Clave = "@dni";
                Parametro tipoCliente = new Parametro();
                tipoCliente.Clave = "@tipocliente";
                tipoCliente.Valor = Convert.ToInt32(cboTipo.SelectedValue);
                filtros.Add(nombre);
                filtros.Add(apellido);
                filtros.Add(dni);
                filtros.Add(tipoCliente);

                string filtrosJson = JsonConvert.SerializeObject(filtros);
                string url = "https://localhost:7188/clienteFiltro";
                var result = await ClientSingleton.GetInstancia().PostAsync(url, filtrosJson);
                List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(result);

                foreach (Cliente item in lst)
                {
                    dgvClientes.Rows.Add(new object[] { item.IdCliente, item.Nombre, item.Apellido, item.Barrio, item.Calle, item.Altura, item.NroDoc, item.NroTel });
                }
            }

        }

        private bool validar()
        {
            bool ok = true;

            if (cboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un tipo de Cliente");
                ok = false;
            }
            
            return ok;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {


        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                lblNombre.Text = "Empresa :";
                txtApellido.Enabled = false;
            }
            if (cboTipo.SelectedIndex == 1)
            {
                lblNombre.Text = "Nombre :";
                txtApellido.Enabled = true;
            }

        }
    }
}
