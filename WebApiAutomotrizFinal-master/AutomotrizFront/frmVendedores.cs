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
    public partial class frmVendedores : Form
    {
        private FabricaServicios oFabrica;
        private IServicio oServicio;
        public frmVendedores()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private void frmVendedores_Load(object sender, EventArgs e)
        {
            numVentas.Value = 1;
        }

        private async void btnConsultarFiltro_Click(object sender, EventArgs e)
        {
            dgvVendedores.Rows.Clear();

            if (validar())
            {
                List<Parametro> filtros = new List<Parametro>();
                Parametro nombre = new Parametro();
                nombre.Clave = "@nombre";
                nombre.Valor = Convert.ToString(txtNombre.Text);
                Parametro apellido = new Parametro();
                apellido.Clave = "@apellido";
                apellido.Valor = Convert.ToString(txtApellido.Text);
                Parametro ventas = new Parametro();
                ventas.Clave = "@vtas";
                ventas.Valor = Convert.ToInt32(numVentas.Value);
                filtros.Add(nombre);
                filtros.Add(apellido);
                filtros.Add(ventas);

                string filtrosJson= JsonConvert.SerializeObject(filtros);
                string url = "https://localhost:7188/vendedorFiltro";
                var result = await ClientSingleton.GetInstancia().PostAsync(url, filtrosJson);
                List<Vendedor> lst = JsonConvert.DeserializeObject<List<Vendedor>>(result);
                foreach (Vendedor item in lst)
                {
                    dgvVendedores.Rows.Add(new object[] { item.IdVendedor, item.Nombre, item.Apellido, item.Calle, item.Altura, item.Email, item.NroTel, item.NroDoc, item.Barrio,item.CantVentas});
                }

        }

    }

        private bool validar()
        {
            bool ok = true;

            if (numVentas.Value <= -1)
            {
                MessageBox.Show("Numero de ventas no valido!");
                ok = false;
            }
            return ok;
        }

        private async void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            dgvVendedores.Rows.Clear();

            string url = "https://localhost:7188/api/Vendedores";
            var result = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Vendedor> lst = JsonConvert.DeserializeObject<List<Vendedor>>(result);
            foreach (Vendedor item in lst)
            {
                dgvVendedores.Rows.Add(new object[] { item.IdVendedor, item.Nombre, item.Apellido, item.Calle, item.Altura, item.Email, item.NroTel, item.NroDoc, item.Barrio,item.CantVentas });
            }
        }
    }
}
