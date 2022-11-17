using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutomotrizBackend.Datos
{
    public class HelperSingleton
    {
        private static HelperSingleton instancia;
        private SqlConnection cnn;

        private HelperSingleton()
        {
            cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=Automotriz_ProgIIDef;Integrated Security=True");
        }
        public static HelperSingleton ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new HelperSingleton();
            return instancia;
        }
        public DataTable ConsultarUser(string NombreSp)
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
    }
}
