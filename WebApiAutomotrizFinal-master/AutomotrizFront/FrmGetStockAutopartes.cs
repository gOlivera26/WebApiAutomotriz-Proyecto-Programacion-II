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
    public partial class FrmGetStockAutopartes : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        public FrmGetStockAutopartes()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
        }

        private async void FrmGetStockAutopartes_Load(object sender, EventArgs e)
        {
            await CargarMarcasAsync();
            await CargarModelosAsyn();


        }
        private async Task CargarModelosAsyn()
        {
            string url = "https://localhost:7188/modelos";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Modelos> lst = JsonConvert.DeserializeObject<List<Modelos>>(data);
            cboModelos.DataSource = lst;
            cboModelos.ValueMember = "IdModelo";
            cboModelos.DisplayMember = "Nombre";
            cboModelos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarMarcasAsync()
        {
            string url = "https://localhost:7188/marcas";
            var data = await ClientSingleton.GetInstancia().GetAsync(url);
            List<Marcas> lst = JsonConvert.DeserializeObject<List<Marcas>>(data);
            cboMarcas.DataSource = lst;
            cboMarcas.ValueMember = "IdMarca";
            cboMarcas.DisplayMember = "Nombre";
            cboMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnConsultarAutoparteFiltro_Click(object sender, EventArgs e)
        {
            dgvStockAutopartes.Rows.Clear();
            List<Parametro> filtros = new List<Parametro>();
            Parametro modelo = new Parametro();
            modelo.Clave = "@modelo";
            modelo.Valor = Convert.ToInt32(cboModelos.SelectedValue);
            Parametro marca = new Parametro();
            marca.Clave = "@marca";
            marca.Valor = Convert.ToInt32(cboMarcas.SelectedValue);
            filtros.Add(modelo);
            filtros.Add(marca);


            string filtrosJson = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:7188/api/Autopartes";
            var result = await ClientSingleton.GetInstancia().PostAsync(url, filtrosJson);
            List<Autopartes>lst = JsonConvert.DeserializeObject<List<Autopartes>>(result);
            foreach (Autopartes item in lst)
            {
                dgvStockAutopartes.Rows.Add(new object[] { item.IdAutoparte, item.Descripcion, item.Precio, item.Stock, item.Marca, item.Modelo});
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
