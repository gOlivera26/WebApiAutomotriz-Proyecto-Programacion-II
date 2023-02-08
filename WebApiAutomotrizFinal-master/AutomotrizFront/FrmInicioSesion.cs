using AutomotrizBackend.Datos;
using AutomotrizBackend.Dominio;
using AutomotrizBackend.Servicios.Interfaces;
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
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
            personalizarDiseno();
        }
        private List<Usuario> lUsuario = new List<Usuario>();
        private HelperSingleton oHelper = HelperSingleton.ObtenerInstancia();
        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            btnModificarV.Enabled = false;
            btnAutopartes.Enabled = false;
            btnVehiculos.Enabled = false;
            btnConsulta.Enabled = false;
            btnPersonas.Enabled = false;

            groupBox1.Show();

            DataTable tabla = new DataTable();

            tabla = oHelper.ConsultarUser("SP_USUARIOS");


            foreach (DataRow fila in tabla.Rows)
            {
                Usuario nuevoUser = new Usuario();

                nuevoUser.usuario = fila["Usuario"].ToString();
                nuevoUser.contrasenia = fila["Contrasenia"].ToString();
                nuevoUser.tipoUsuario = fila["Tipo_Usuario"].ToString();

                lUsuario.Add(nuevoUser);
            }

        }
       
        private void personalizarDiseno()
        {
            panelSubmenuAuto.Visible = false;
            panelSubmenuVehi.Visible = false;
            btnClientes.Visible = false;
            btnVendedores.Visible = false;
        }
        private void ocultarSubmenu()
        {
            if (panelSubmenuAuto.Visible == true)
            {
                panelSubmenuAuto.Visible = false;
            }
            if (panelSubmenuVehi.Visible == true)
            {
                panelSubmenuVehi.Visible = false;
            }
            if(btnClientes.Visible == true)
            {
                btnClientes.Visible=false;
            }
            if (btnVendedores.Visible == true)
            {
                btnVendedores.Visible = false;
            }
        }
        private void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void mostrarBotones()
        {
            if(btnClientes.Visible == false && btnVendedores.Visible==false)
            {
                ocultarSubmenu();
                btnClientes.Visible = true;
                btnVendedores.Visible = true;
            }
            else
            {
                btnClientes.Visible = false;
                btnVendedores.Visible = false;
            }
        }
        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAutopartes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubmenuAuto);

        }
        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubmenuVehi);
            
        }
        public void button1_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
            abrirFormulario(new FrmGetStockAutopartes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();

        }

        private void btnConsultarV_Click(object sender, EventArgs e)
        {
            ocultarSubmenu();
            abrirFormulario(new FrmGetStockVehiculos());
        }

        private void butbtnModificarV_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmInsertVehiculos());
            ocultarSubmenu();
        }
        private Form formActivo = null;
        private void abrirFormulario(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelForms.Controls.Add(formHijo);
            panelForms.Tag = formHijo;
            formHijo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panelSubmenuVehi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFactura_Click_1(object sender, EventArgs e)
        {
            ocultarSubmenu();
            abrirFormulario(new FrmAltaFacturaVehiculo());
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            bool confirmacionInicio = false;
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                foreach (Usuario oUsuario in lUsuario)
                {
                    if (txtUser.Text == oUsuario.usuario && txtPass.Text == oUsuario.contrasenia)
                    {
                        if (oUsuario.tipoUsuario == "Admin")
                        {
                            this.DialogResult = DialogResult.Abort;//Admin
                            confirmacionInicio = true;
                            btnModificarV.Enabled = true;
                            btnVehiculos.Enabled = true;
                            btnAutopartes.Enabled = true;
                            btnConsulta.Enabled = true;
                            btnPersonas.Enabled = true;
                            groupBox1.Hide();
                            break;
                        }
                        else if (oUsuario.tipoUsuario == "Vendedor")
                        {
                            this.DialogResult = DialogResult.Ignore;
                            confirmacionInicio = true;
                            btnVehiculos.Enabled = true;
                            btnAutopartes.Enabled = true;
                            btnConsulta.Enabled = true;
                            groupBox1.Hide();
                        }
                        else
                        {
                            confirmacionInicio = false;
                        }
                    }
                }
                if (confirmacionInicio)
                {
                    MessageBox.Show("Inicio de Sesión exitoso!", "Inicio Sesión", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Campo usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Campo usuario y/o contraseña vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsutarF_Click(object sender, EventArgs e)
        {
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            
            ocultarSubmenu();
            abrirFormulario(new FrmConsultaFacturas());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonas_Click_1(object sender, EventArgs e)
        {
            mostrarBotones();
        }
    }
}