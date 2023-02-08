using AutomotrizBackend.Datos.Interfaces;
using AutomotrizBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackend.Datos.Implementaciones
{
    public class FacturasDao : IFacturasDao
    {
        public bool AltaVehiculo(Facturas f)
        {
            bool ok = false;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_Insertar_Maestro", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@formaPago", f.IdFormaPago);
                cmd.Parameters.AddWithValue("@formaEntrega", f.IdFormaEntrega);
                cmd.Parameters.AddWithValue("@cliente", f.IdCliente);
                cmd.Parameters.AddWithValue("@vendedor", f.idVendedor);
                cmd.Parameters.AddWithValue("@fecha", f.Fecha);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro_factura";
                param.DbType = DbType.Int32;
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                int nroFactura = (int)param.Value;



                foreach (DetallesFacturas dt in f.Detalles)
                {

                    SqlCommand cmdDetalle = new SqlCommand("SP_Insertar_Detalle", cnn, t);
                    
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@nro_factura", nroFactura);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dt.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@vehiculo", dt.Vehiculo.IdVehiculo);

                    cmdDetalle.ExecuteNonQuery();
                }
                t.Commit();
                ok = true;
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

       
        public List<Autopartes> CargarAutopartes()
        {
            List<Autopartes> lst = new List<Autopartes>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Autopartes");
            foreach (DataRow dr in tabla.Rows)
            {
                Autopartes a = new Autopartes();
                a.IdAutoparte = Convert.ToInt32(dr["id_autoparte"]);
                a.Descripcion = Convert.ToString(dr["descripcion"]);
                a.Precio = Convert.ToDouble(dr["pre_unitario"]);
                a.Marca.Nombre = Convert.ToString(dr["marca"]);
                a.Modelo.Nombre = Convert.ToString(dr["modelo"]);
                lst.Add(a);

            }
            return lst;
        }

        public List<Autopartes> CargarAutopartesFiltros(List<Parametro> criterios)
        {

            List<Autopartes> lst = new List<Autopartes>();
            DataTable tabla = new DataTable();
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("Sp_Consultar_Autopartes_Filtros", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    if (p.Valor == null)
                        cmd.Parameters.AddWithValue(p.Clave, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(p.Clave, p.Valor.ToString());
                }
                tabla.Load(cmd.ExecuteReader());

                foreach (DataRow dr in tabla.Rows)
                {
                    Autopartes a = new Autopartes();

                    a.IdAutoparte = Convert.ToInt32(dr["id_autoparte"]);
                    a.Descripcion = Convert.ToString(dr["descripcion"]);
                    a.Precio = Convert.ToDouble(dr["pre_unitario"]);
                    a.Stock = Convert.ToInt32(dr["stock"]);
                    a.Marca.Nombre = Convert.ToString(dr["marca"]);
                    a.Modelo.Nombre = Convert.ToString(dr["modelo"]);

                    lst.Add(a);
                }
                cnn.Close();


            }
            catch (Exception)
            {
                cnn.Close();
            }
            return lst;
        }


        public List<Cliente> CargarClientes()
        {
            List<Cliente> lst = new List<Cliente>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Clientes");
            foreach (DataRow dr in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.IdCliente = Convert.ToInt32(dr["id_cliente"]);
                c.Nombre = Convert.ToString(dr["nombre"]);
                c.Apellido = Convert.ToString(dr["apellido"]);
                c.Barrio = Convert.ToString(dr["barrio"]);
                c.Calle = Convert.ToString(dr["calle"]);
                c.Altura = Convert.ToInt32(dr["Altura"]);
                c.TipoCliente.Tipo = Convert.ToString(dr["nombre"]);
                c.NroDoc = Convert.ToInt32(dr["nro_doc"]);
                c.NroTel = Convert.ToInt32(dr["nro_tel"]);
                c.Email = Convert.ToString(dr["email"]);
                lst.Add(c);

            }
            return lst;
        }

        public List<Cliente> CargarClientesFiltro(List<Parametro> criterios)
        {
            List<Cliente> lst = new List<Cliente>();
            DataTable tabla = new DataTable();
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SP_Consultar_ClienteFiltro", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    if (p.Valor == null)
                        cmd.Parameters.AddWithValue(p.Clave, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(p.Clave, p.Valor.ToString());
                }
                tabla.Load(cmd.ExecuteReader());

                foreach (DataRow dr in tabla.Rows)
                {
                    Cliente c = new Cliente();
                    c.IdCliente = Convert.ToInt32(dr["id_cliente"]);
                    c.Nombre = Convert.ToString(dr["nombre"]);
                    c.Apellido = Convert.ToString(dr["apellido"]);
                    c.Barrio = Convert.ToString(dr["barrio"]);
                    c.Calle = Convert.ToString(dr["calle"]);
                    c.Altura = Convert.ToInt32(dr["Altura"]);
                    c.TipoCliente.Tipo = Convert.ToString(dr["nombre"]);
                    c.NroDoc = Convert.ToInt32(dr["nro_doc"]);
                    c.NroTel = Convert.ToInt32(dr["nro_tel"]);
                    c.Email = Convert.ToString(dr["email"]);
                    lst.Add(c);

                }
                cnn.Close();
            }

            catch (Exception)
            {
                cnn.Close();
            }
            return lst;
        }

        public List<FacConsulta> CargarFacturas(List<Parametro> criterios)
        {
            
                List<FacConsulta> lst = new List<FacConsulta>();
                DataTable tabla = new DataTable();
                SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
                try
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("SP_Consultar_Facturas_Filtros", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (Parametro p in criterios)
                    {
                        if (p.Valor == null)
                            cmd.Parameters.AddWithValue(p.Clave, DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue(p.Clave, p.Valor.ToString());
                    }
                    tabla.Load(cmd.ExecuteReader());

                    foreach (DataRow dr in tabla.Rows)
                    {
                     FacConsulta f = new FacConsulta();
                        f.NroFactura = Convert.ToInt32(dr["nro_factura"]);
                        f.IdCliente.TipoCliente.Tipo = Convert.ToString(dr["nombre"]);
                        f.Fecha = Convert.ToDateTime(dr["fecha"]);
                        f.IdFormaEntrega.Forma = Convert.ToString(dr["forma_entrega"]);
                        f.IdFormaPago.Forma = Convert.ToString(dr["forma_pago"]);

                        lst.Add(f);
                    }
                    cnn.Close();


                }
                catch (Exception)
                {
                    cnn.Close();
                }
                return lst;
            
        }

        public List<FormasPago> CargarFormaPago()
        {
            List<FormasPago> lst = new List<FormasPago>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Forma_Pago");
            foreach (DataRow dr in tabla.Rows)
            {
                FormasPago f = new FormasPago();
                f.IdFormaPago = Convert.ToInt32(dr["id_forma_pago"]);
                f.Forma = Convert.ToString(dr["forma_pago"]);
                lst.Add(f);
            }
            return lst;
        }

        public List<Vehiculo> CargarVehiculosFiltros(List<Parametro> criterios)
        {
            List<Vehiculo> lst = new List<Vehiculo>();
            DataTable tabla = new DataTable();
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SP_Consultar_Vehiculos_Filtros", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    if (p.Valor == null)
                        cmd.Parameters.AddWithValue(p.Clave, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(p.Clave, p.Valor.ToString());
                }
                tabla.Load(cmd.ExecuteReader());

                foreach (DataRow dr in tabla.Rows)
                {
                    Vehiculo v = new Vehiculo();
                    v.IdVehiculo = Convert.ToInt32(dr["id_vehiculo"]);
                    v.Descripcion = Convert.ToString(dr["descripcion"]);
                    v.Precio = Convert.ToDouble(dr["pre_unitario"]);
                    v.Stock = Convert.ToInt32(dr["stock"]);
                    v.Marca.Nombre = Convert.ToString(dr["marca"]);
                    v.Modelo.Nombre = Convert.ToString(dr["modelo"]);
                    v.Color.Nombre = Convert.ToString(dr["color"]);
                    lst.Add(v);
                }
                cnn.Close();


            }
            catch (Exception)
            {
                cnn.Close();
            }
            return lst;
        }

        public List<Vendedor> CargarVendedores()
        {
            List<Vendedor> lst = new List<Vendedor>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Vendedores");
            foreach (DataRow dr in tabla.Rows)
            {
                Vendedor v = new Vendedor();
                v.IdVendedor = Convert.ToInt32(dr["id_vendedor"]);
                v.Nombre = Convert.ToString(dr["nombre"]);
                v.Apellido = Convert.ToString(dr["apellido"]);
                v.Calle = Convert.ToString(dr["calle"]);
                v.Altura = Convert.ToInt32(dr["altura"]);
                v.Email = Convert.ToString(dr["email"]);
                v.NroTel = Convert.ToDouble(dr["nro_tel"]);
                v.NroDoc = Convert.ToInt32(dr["nro_doc"]);
                v.Barrio = Convert.ToString(dr["barrio"]);

                lst.Add(v);
            }
            return lst;
        }

        public bool CrearAutoparte(Autopartes a)
        {
            bool ok = false;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_Inser_Autopartes", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", a.Descripcion);
                cmd.Parameters.AddWithValue("@precio", a.Precio);
                cmd.Parameters.AddWithValue("@stock", a.Stock);
                cmd.Parameters.AddWithValue("@stock_minimo", a.StockMinimo);
                cmd.Parameters.AddWithValue("@marca", a.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@modelo", a.Modelo.IdModelo);
                cmd.ExecuteNonQuery();

                t.Commit();
                ok = true;
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

        public bool CrearCliente(Cliente c)
        {
            bool ok = false;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_Insert_Cliente", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreC", c.Nombre);
                cmd.Parameters.AddWithValue("@apellido", c.Apellido);
                cmd.Parameters.AddWithValue("@calle", c.Calle);
                cmd.Parameters.AddWithValue("@altura", c.Altura);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@nroTel", c.NroTel);
                cmd.Parameters.AddWithValue("@tipoCliente", c.TipoCliente.IdTipoCliente);
                cmd.Parameters.AddWithValue("@nroDoc", c.NroDoc);
                cmd.Parameters.AddWithValue("@barrio", c.Barrio);
                cmd.ExecuteNonQuery();

                t.Commit();
                ok = true;
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

        public bool CrearVehiculo(Vehiculo v)
        {
            bool ok = false;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_Inser_Vehiculos", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", v.Descripcion);
                cmd.Parameters.AddWithValue("@precio", v.Precio);
                cmd.Parameters.AddWithValue("@stock", v.Stock);
                cmd.Parameters.AddWithValue("@marca", v.Marca.IdMarca);
                cmd.Parameters.AddWithValue("@modelo", v.Modelo.IdModelo);
                cmd.Parameters.AddWithValue("@color", v.Color.IdColor);

                cmd.ExecuteNonQuery();

                t.Commit();
                ok = true;
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

        public List<Colores> GetColores()
        {
            List<Colores> colores = new List<Colores>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Colores");
            foreach (DataRow dr in tabla.Rows)
            {
                Colores c = new Colores();
                c.IdColor = Convert.ToInt32(dr["id_color"]);
                c.Nombre = Convert.ToString(dr["color"]);
                colores.Add(c);
            }
            return colores;
        }

        public List<FormaEntrega> GetFormaEntrega()
        {
            List<FormaEntrega> lst = new List<FormaEntrega>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_FormaEntrega");
            foreach (DataRow dr in tabla.Rows)
            {
                FormaEntrega fe = new FormaEntrega();
                fe.IdFormaEntrega = Convert.ToInt32(dr["id_forma_entrega"]);
                fe.Forma = Convert.ToString(dr["forma_entrega"]);
                lst.Add(fe);

            }
            return lst;
        }

        public List<Marcas> GetMarcas()
        {
            List<Marcas> lst = new List<Marcas>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Marcas");
            foreach (DataRow dr in tabla.Rows)
            {
                Marcas m = new Marcas();
                m.IdMarca = Convert.ToInt32(dr["id_marca"]);
                m.Nombre = Convert.ToString(dr["marca"]);
                lst.Add(m);
            }
            return lst;
        }

        public List<Modelos> GetModelos()
        {
            List<Modelos> lst = new List<Modelos>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Modelos");
            foreach (DataRow dr in tabla.Rows)
            {
                Modelos m = new Modelos();
                m.IdModelo = Convert.ToInt32(dr["id_modelo"]);
                m.Nombre = Convert.ToString(dr["modelo"]);
                lst.Add(m);
            }
            return lst;
        }

        public List<TipoCliente> GetTipo()
        {
            List<TipoCliente> lst = new List<TipoCliente>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_TipoCliente");
            foreach (DataRow dr in tabla.Rows)
            {
                TipoCliente tc = new TipoCliente();
                tc.IdTipoCliente = Convert.ToInt32(dr["id_tipo_cliente"]);
                tc.Tipo = Convert.ToString(dr["nombre"]);
                lst.Add(tc);
            }
            return lst;
        }

        public List<Vehiculo> GetVehiculos()
        {
            List<Vehiculo> lst = new List<Vehiculo>();
            DataTable tabla = HelperDao.ObtenerInstancia().Consultar("SP_Consultar_Vehiculos");
            foreach (DataRow dr in tabla.Rows)
            {
                Vehiculo v = new Vehiculo();
                v.IdVehiculo = Convert.ToInt32(dr["id_vehiculo"]);
                v.Descripcion = Convert.ToString(dr["descripcion"]);
                v.Precio = Convert.ToDouble(dr["pre_unitario"]);
                v.Stock = Convert.ToInt32(dr["stock"]);
                v.Marca.IdMarca = Convert.ToInt32(dr["id_marca"]);
                v.Modelo.IdModelo = Convert.ToInt32(dr["id_modelo"]);
                v.Color.IdColor = Convert.ToInt32(dr["id_color"]);
                v.Marca.Nombre = Convert.ToString(dr["marca"]);
                v.Modelo.Nombre = Convert.ToString(dr["modelo"]);
                v.Color.Nombre = Convert.ToString(dr["color"]);
                lst.Add(v);

            }
            return lst;
        }

    }
}
