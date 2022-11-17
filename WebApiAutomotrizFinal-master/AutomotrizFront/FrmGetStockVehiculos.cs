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
    public partial class FrmGetStockVehiculos : Form
    {
        private IServicio oServicio;
        private FabricaServicios oFabrica;
        Vehiculo v;
        public FrmGetStockVehiculos()
        {
            InitializeComponent();
            oFabrica = new FabricaServiciosImp();
            oServicio = oFabrica.CrearServicio();
            v = new Vehiculo();
        }

        private async void FrmGetStockVehiculos_Load(object sender, EventArgs e)
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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

               dgvStockVehiculos.Rows.Clear();
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
                string url = "https://localhost:7188/porFiltros";
                var result = await ClientSingleton.GetInstancia().PostAsync(url, filtrosJson);

                List<Vehiculo> lst= JsonConvert.DeserializeObject<List<Vehiculo>>(result);

                foreach (Vehiculo item in lst)
                {
                    dgvStockVehiculos.Rows.Add(new object[] { item.IdVehiculo, item.Descripcion, item.Precio, item.Stock, item.Marca, item.Modelo, item.Color });
                }

            

        }
    }
}
