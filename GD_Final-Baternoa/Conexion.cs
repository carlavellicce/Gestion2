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
        SqlDataReader dr;
        SqlCommandBuilder cb;
        SqlDataAdapter da;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Gestion-V2;User ID=sa;Password=12345");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto la base de datos: " + ex.ToString());
            }
        }

       

        

       
       

       

        public bool insertar(string sql)
        {
            cn.Open();
            cmd = new SqlCommand(sql,cn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }
            else { return false; }

        }
    }
}
