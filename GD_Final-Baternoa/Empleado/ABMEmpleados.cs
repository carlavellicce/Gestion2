using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GD_Final_Baternoa.Empleado
{
    public partial class ABMEmpleados : Form
    {
        Conexion c = new Conexion();

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Gestion-V2;Persist Security Info=True;User ID=sa;Password=12345");
        public ABMEmpleados()
        {
            InitializeComponent();
            cargarProvincias();
        }

        public void cargarProvincias()
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdProvincia,NombreProvincia FROM provincia", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Close();

            DataRow fila = dt.NewRow();
            fila["NombreProvincia"] = "Selecciona una Provincia";
            dt.Rows.InsertAt(fila, 0);

            comboBoxProvinciaEmpleado.ValueMember = "IdProvincia";
            comboBoxProvinciaEmpleado.DisplayMember = "NombreProvincia";
            comboBoxProvinciaEmpleado.DataSource = dt;

        }
        public void cargarLocalidad(string IdProvincia)
        {
            // con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdLocalidad,NombreLocalidad FROM localidad WHERE idProvincia = @IdProvincia", con);
            cmd.Parameters.AddWithValue("IdProvincia", IdProvincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //con.Close();

            DataRow dr = dt.NewRow();
            dr["NombreLocalidad"] = "Selecciona una Localidad";
            dt.Rows.InsertAt(dr, 0);

            comboBoxLocalidadEmpleado.ValueMember = "IdLocalidad";
            comboBoxLocalidadEmpleado.DisplayMember = "NombreLocalidad";
            comboBoxLocalidadEmpleado.DataSource = dt;
        }

        
        private void ABMEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLocalidadEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxProvinciaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvinciaEmpleado.SelectedValue.ToString() != null)
            {
                string IdProvincia = comboBoxProvinciaEmpleado.SelectedValue.ToString();
                cargarLocalidad(IdProvincia);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT into Domicilio (Calle, Numero,idlocalidad) values('"+textBoxCalle.Text +"',"+ Convert.ToInt32(textBoxNumeroCalle.Text)+","+comboBoxLocalidadEmpleado.ValueMember +")";
            if (c.insertar(sql))
            {
               // int idDomic =;
                    MessageBox.Show("Registro insertado");
            }
            else { MessageBox.Show("Error No se incerto el registro"); }

            string consulta = "SELECT idDomicilio from Domicilio WHERE  Calle = '" + textBoxCalle.Text + "' AND Numero = " + Convert.ToInt32(textBoxNumeroCalle.Text) + " AND idLocalidad = " + comboBoxLocalidadEmpleado.ValueMember + "";
            SqlCommand sqlc = new SqlCommand(consulta,con);
            con.Open();
            SqlDataReader res = sqlc.ExecuteReader();
            while (res.Read())
            {
                int iddom = res.GetInt32(0);
            }
            con.Close();
        }

    }
}
