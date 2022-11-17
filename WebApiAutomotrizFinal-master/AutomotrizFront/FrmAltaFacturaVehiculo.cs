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
    public partial class FrmAltaFacturaVehiculo : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        private Facturas nueva;
        public FrmAltaFacturaVehiculo()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
            nueva = new Facturas();
        }

        private async void FrmAltaFacturaVehiculo_Load(object sender, EventArgs e)
        {
            await CargarClientes();
            await CargarVendedores();
            await CargarVehiculosAsync();
           
            await CargarFormaEntregaAsync();
            await CargarFormaPagoAsync();
            LimpiarCampos();
            txtPrecio.Enabled = false;
            
        }

     
        private async Task CargarFormaPagoAsync()
        {
            string url = "https://localhost:7188/FormaPago";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<FormasPago>lst = JsonConvert.DeserializeObject<List<FormasPago>>(data);
            cboFormaPago.DataSource = lst;
            cboFormaPago.ValueMember = "IdFormaPago";
            cboFormaPago.DisplayMember = "Forma";
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarFormaEntregaAsync()
        {
            string url = "https://localhost:7188/FormaEntregas";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<FormaEntrega>lst= JsonConvert.DeserializeObject<List<FormaEntrega>>(data);
            cboFormaEntrega.DataSource = lst;
            cboFormaEntrega.ValueMember = "IdFormaEntrega";
            cboFormaEntrega.DisplayMember = "Forma";
            cboFormaEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void LimpiarCampos()
        {
            cboVehiculos.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            lblDescripcion.Text = "Estado: ";
            lblColor.Text = "Color: ";
            lblMarca.Text = "Marca: ";
            lblModelo.Text = "Modelo: ";
            txtPrecio.Text = "";
            NumCantidad.Value = 1;
            dtpFecha.Enabled = false;
           
            
        }

        private async Task CargarVehiculosAsync()
        {
            string url = "https://localhost:7188/api/Vehiculos";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Vehiculo> lst = JsonConvert.DeserializeObject<List<Vehiculo>>(data);
            cboVehiculos.DataSource = lst;
            cboVehiculos.ValueMember = "IdVehiculo";
            cboVehiculos.DisplayMember = "Marca";
            cboVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

     

        private async Task CargarVendedores()
        {
            string url = "https://localhost:7188/api/Vendedores";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Vendedor>lst = JsonConvert.DeserializeObject<List<Vendedor>>(data);
            cboVendedor.DataSource = lst;
            cboVendedor.ValueMember = "IdVendedor";
            cboVendedor.DisplayMember = "Apellido";
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarClientes()
        {
            string url = "https://localhost:7188/api/Cliente";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            cboCliente.DataSource = lst;
            cboCliente.ValueMember = "IdCliente";
            cboCliente.DisplayMember = "Apellido";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private async void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            await GuardarFacturaAsync();
                                      
        }

        private async Task GuardarFacturaAsync()
        {

            nueva.IdFormaPago = (int)cboFormaPago.SelectedValue;
            nueva.IdFormaEntrega = (int)cboFormaEntrega.SelectedValue;
            nueva.idVendedor = (int)cboVendedor.SelectedValue;
            nueva.IdCliente = (int)cboCliente.SelectedValue;


            nueva.Fecha = dtpFecha.Value;
            string bodyContent = JsonConvert.SerializeObject(nueva);

            string url = "https://localhost:7188/AltaVehiculo";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Factura Registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                dgvDetalles.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Fallo");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo v = (Vehiculo)cboVehiculos.SelectedItem;
            v.IdVehiculo = (int)cboVehiculos.SelectedValue;
     
            int cantidad = Convert.ToInt32(NumCantidad.Value);
            double precio = Convert.ToDouble(txtPrecio.Text);
            //Autopartes a = (Autopartes)cboAutoparte.SelectedItem;
            //a.IdAutoparte = (int)cboAutoparte.SelectedValue;
            

            DetallesFacturas df = new DetallesFacturas(precio, cantidad, v);
            nueva.AgregarDetalle(df);
            dgvDetalles.Rows.Add(new object[] { v.IdVehiculo, v.Descripcion, v.Marca, v.Modelo, v.Color, df.PrecioUnitario, df.Cantidad });
        }

        private async void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboVehiculos.SelectedIndex >= 0)
            {
                Vehiculo v = (Vehiculo)cboVehiculos.SelectedItem;
                lblDescripcion.Text = "Estado: "+v.Descripcion;
                lblColor.Text = "Color: " + v.Color;
                lblMarca.Text = "Marca: " + v.Marca;
                lblModelo.Text = "Modelo: " + v.Modelo;
                txtPrecio.Text = v.Precio.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmInsertCliente frmCliente = new FrmInsertCliente();
            frmCliente.Show();
        }
    }
}
