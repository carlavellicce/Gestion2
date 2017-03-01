using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GD_Final_Baternoa
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter dr;

        public void abrirConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Gestion-V2;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto la base de datos: " + ex.ToString());
            }
        }
        public void cerrarConexion()
        {
            cn.Close();
        }

    }
}
