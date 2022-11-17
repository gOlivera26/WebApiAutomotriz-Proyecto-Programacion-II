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
    public partial class FrmInsertCliente : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;

        public FrmInsertCliente()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private async void FrmInsertCliente_Load(object sender, EventArgs e)
        {
            await CargarTipoCliente();
        }

        private async Task CargarTipoCliente()
        {
            string url = "https://localhost:7188/tipoCliente";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<TipoCliente>lst = JsonConvert.DeserializeObject<List<TipoCliente>>(data);
            cboTipo.DataSource = lst;
            cboTipo.ValueMember = "IdTipoCliente";
            cboTipo.DisplayMember = "Tipo";
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTipo.SelectedIndex == 1)
            {
                lblNombre.Text = "Nombre: ";
                txtApellido.Enabled = true;
                txtNumDoc.Enabled = true;
            }
            else if (cboTipo.SelectedIndex == 0)
            {
                lblNombre.Text = "Nombre Empresa: ";
                txtApellido.Enabled = false;
                txtNumDoc.Enabled = true;
            }
            else if(cboTipo.SelectedIndex == 2)
            {
                lblNombre.Text = "Nombre: ";
                txtApellido.Enabled = true;
                txtNumDoc.Enabled = true;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                foreach (DataGridViewRow item in dgvDetallesCliente.Rows)
                {
                    if (item.Cells["ColNroDoc"].Value.ToString().Equals(txtNumDoc.Text))
                    {
                        MessageBox.Show("El Documento/Cuil :" + txtNumDoc.Text + " Ya se encuentra ingresado!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                Cliente c = new Cliente();
                c.Nombre = txtNombre.Text;
                c.Apellido = txtApellido.Text;
                c.NroDoc = Convert.ToInt32(txtNumDoc.Text);
                c.Barrio = txtBarrio.Text;
                c.Calle = txtCalle.Text;
                c.Altura = Convert.ToInt32(txtAltura.Text);
                c.Email = txtEmail.Text;
                c.NroTel = Convert.ToInt32(txtNumeroTel.Text);
                dgvDetallesCliente.Rows.Add(new object[] {c.IdCliente,c.Nombre,c.Apellido,c.NroDoc,c.Barrio,c.Calle,c.Altura,c.Email,c.NroTel});

            }
        }

        private bool validar()
        {
            bool ok = true;
            if (cboTipo.SelectedIndex != 0 && txtApellido.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar un apellido","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                ok = false;
            }
            else if (txtBarrio.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar un Barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            else if (txtCalle.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar una Calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }

            else if (txtAltura.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar una Altura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            else if (txtEmail.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar un Email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            else if (txtNumeroTel.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe agregar un Numero de telefono", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ok = false;
            }
            return ok;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nombre = txtNombre.Text;
            c.Apellido = txtApellido.Text;
            c.NroDoc = Convert.ToInt32(txtNumDoc.Text);
            c.Barrio = txtBarrio.Text;
            c.Calle = txtCalle.Text;
            c.Altura = Convert.ToInt32(txtAltura.Text);
            c.Email = txtEmail.Text;
            c.NroTel = Convert.ToInt32(txtNumeroTel.Text);
            c.TipoCliente = (TipoCliente)cboTipo.SelectedItem;

            var Ok = await GuardarClienteAsync(c);
            if (Ok)
            {
                MessageBox.Show("Cliente guardado con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDetallesCliente.Rows.Clear();
                LimpiarCampos();
            }
            else
                MessageBox.Show("No se pudo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void LimpiarCampos()
        {
            txtAltura.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtCalle.Text = "";
            txtNumDoc.Text = "";
            txtNumeroTel.Text = "";
            txtEmail.Text = "";
        }

        private async Task<bool> GuardarClienteAsync(Cliente c)
        {
            string url = "https://localhost:7188/CrearCliente";
            string clienteJson = JsonConvert.SerializeObject(c);
            var result = await ClientSingleton.GetInstancia().PostAsync(url,clienteJson);
            return result.Equals("true");
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Error, el campo debe ser de tipo numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeroTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Error, el campo debe ser de tipo numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
