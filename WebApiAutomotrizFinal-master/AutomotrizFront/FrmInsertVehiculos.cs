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
using static System.Net.WebRequestMethods;

namespace AutomotrizFront
{
    public partial class FrmInsertVehiculos : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public FrmInsertVehiculos()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private async void FrmInsertVehiculos_Load(object sender, EventArgs e)
        {
            await CargarMarcasAsync();
            await CargarModelosAsyn();
            await CargarColoresAsync();
            txtDescripcion.Text = "0Km";


        }

        private async Task CargarColoresAsync()
        {
            string url = "https://localhost:7188/colores";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Colores> lst = JsonConvert.DeserializeObject<List<Colores>>(data);
            cboColor.DataSource = lst;
            cboColor.ValueMember = "IdColor";
            cboColor.DisplayMember = "Nombre";
            cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarModelosAsyn()
        {
            string url = "https://localhost:7188/modelos";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Modelos> lst = JsonConvert.DeserializeObject<List<Modelos>>(data);
            cboModelo.DataSource = lst;
            cboModelo.ValueMember = "IdModelo";
            cboModelo.DisplayMember = "Nombre";
            cboModelo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarMarcasAsync()
        {
            string url = "https://localhost:7188/marcas";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Marcas>lst = JsonConvert.DeserializeObject<List<Marcas>>(data);
            cboMarcas.DataSource = lst;
            cboMarcas.ValueMember = "IdMarca";
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar una descripcion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPrecio.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar el precio del vehiculo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow item in dgvDetalles.Rows)
            {
                if (item.Cells["ColModelo"].Value.ToString().Equals(cboModelo.Text) && item.Cells["ColMarca"].Value.ToString().Equals(cboMarcas.Text))
                {
                    MessageBox.Show("Modelo: " + cboModelo.Text + " y"+ cboMarcas.Text+" ya se encuentra como detalle!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            Vehiculo v = new Vehiculo();
            v.Descripcion = txtDescripcion.Text;
            v.Precio = Convert.ToDouble(txtPrecio.Text);
            v.Marca = (Marcas)cboMarcas.SelectedItem;
            v.Modelo = (Modelos)cboModelo.SelectedItem;
            v.Color = (Colores)cboColor.SelectedItem;
            dgvDetalles.Rows.Add(new object[] { v.IdVehiculo, v.Descripcion, v.Marca, v.Modelo, v.Color, v.Precio });

        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo();
            v.Descripcion = txtDescripcion.Text;
            v.Precio = Convert.ToDouble(txtPrecio.Text);
            v.Marca = (Marcas)cboMarcas.SelectedItem;
            v.Stock = Convert.ToInt32(numCantidad.Value);
            v.Modelo = (Modelos)cboModelo.SelectedItem;
            v.Color = (Colores)cboColor.SelectedItem;

            var Ok = await GuardarVehiculoAsync(v);
            if (Ok)
            {
                MessageBox.Show("Vehiculo guardado con exito!");
                dgvDetalles.Rows.Clear();
            }
            else
                MessageBox.Show("No se pudo registrar el vehiculo","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
        }

        private async Task<bool> GuardarVehiculoAsync(Vehiculo v)
        {
            string url = "https://localhost:7188/crearVehiculo";
            string vehiculoJson = JsonConvert.SerializeObject(v);
            var result = await ClientSingleton.GetInstancia().PostAsync(url, vehiculoJson);
            return result.Equals("true");
        }
    }
}
