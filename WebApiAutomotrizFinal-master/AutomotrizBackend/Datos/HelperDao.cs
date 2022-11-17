using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Reflection.Metadata;

namespace AutomotrizBackend.Datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection cnn;

        private HelperDao()
        {
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
        }
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperDao();
            return instancia;
        }
        public DataTable ConsultaFiltros(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }
        public DataTable Consultar(string NombreSp)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSp;
            cmd.Connection = cnn;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
        internal bool Ejecutar(string sp, List<Parametro> lst)
        {
            bool respuesta = false;
            SqlTransaction transaccion = null;

            try
            {
                cnn.Open();
                transaccion = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(sp, cnn, transaccion);
                cmd.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    foreach (Parametro param in lst)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                cmd.ExecuteNonQuery();

                transaccion.Commit();
                respuesta = true;
            }
            catch (Exception)
            {
                if (cnn != null)
                    transaccion.Rollback();

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return respuesta;


        }
        public SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }
    }

}