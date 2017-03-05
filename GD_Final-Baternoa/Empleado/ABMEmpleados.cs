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
            SqlCommand cmd = new SqlCommand("SELECT IdLocalidad,NombreLocalidad FROM localidad WHERE IdProvincia = @IdProvincia", con);
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
    }
}
