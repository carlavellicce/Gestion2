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
        DataSet ds = new DataSet();
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

        public void llenarCombo(ComboBox cb) {

            try {
                cmd = new SqlCommand("Select NombreCategoria from CategoriaProducto ", cn);
                
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["NombreCategoria"].ToString());
                    // cb.Items.Add(dr["NombreCategoria"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("No se lleno el ComBox: " + ex.ToString());
            }

        }

        public void llenarCombo2(ComboBox cb, string cad, string atri)
        {

            try
            {
                cmd = new SqlCommand(cad, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[atri].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el ComBox: " + ex.ToString());
            }

            
        }

        public void CargarComboBox(ComboBox cb) {
            string cad = "Select idProvincia,NombreProvincia from Provincia ";
            cmd = new SqlCommand(cad, cn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dr.Fill(tbl);

            cb.DataSource = tbl;
            cb.ValueMember = "idProvincia";
            cb.DisplayMember = "NombreProvincia";
        }

        public void CargarComboBoxAnidado(ComboBox cbb, string idProvincia)
        {
            string cad = "SELECT idLocalidad,NombreLocalidad FROM Localidad WHERE idProvincia = @idProvincia ";
            cmd = new SqlCommand(cad, cn);
            cmd.Parameters.AddWithValue("idProvincia", idProvincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbb.DataSource = dt;
            cbb.ValueMember = "idLocalidad";
            cbb.DisplayMember = "NombreLocalidad";
            
        }

        public void Consulta(string sql, string tabla) { 
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql,cn);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
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
