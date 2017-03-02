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

namespace GD_Final_Baternoa.Proveedor
{
    public partial class ABMProveedores : Form
    {
        Conexion c = new Conexion();

        SqlConnection con = new SqlConnection(@"Data Source=EMYLAVENIA\SQLEXPRESS;Initial Catalog=Gestion-V2;Integrated Security=True");

        public ABMProveedores()
        {
            InitializeComponent();
            cargarProvincias();
        }


        public void cargarProvincias()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdProvincia,NombreProvincia FROM provincia", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow fila = dt.NewRow();
            fila["NombreProvincia"] = "Selecciona una Provincia";
            dt.Rows.InsertAt(fila, 0);

            comboBoxProvinciaProveedor.ValueMember = "IdProvincia";
            comboBoxProvinciaProveedor.DisplayMember = "NombreProvincia";
            comboBoxProvinciaProveedor.DataSource = dt;

        }

        public void cargarLocalidad(string IdProvincia)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdLocalidad,NombreLocalidad FROM localidad WHERE IdProvincia = @IdProvincia", con);
            cmd.Parameters.AddWithValue("IdProvincia", IdProvincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            DataRow dr = dt.NewRow();
            dr["NombreLocalidad"] = "Selecciona una Localidad";
            dt.Rows.InsertAt(dr, 0);

            comboBoxLocalidadProveedor.ValueMember = "IdLocalidad";
            comboBoxLocalidadProveedor.DisplayMember = "NombreLocalidad";
            comboBoxLocalidadProveedor.DataSource = dt;




        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {

//            c.CargarComboBox(comboBoxProvinciaProveedor);

            //c.CargarComboBoxAnidado(comboBoxLocalidadProveedor);


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefono_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvinciaProveedor.SelectedValue.ToString() != null)
            {
                string IdProvincia = comboBoxProvinciaProveedor.SelectedValue.ToString();
                cargarLocalidad(IdProvincia);

            }



            // if (comboBoxProvinciaProveedor.SelectedValue.ToString() != null)
            {
             
            //string provincia = comboBoxProvinciaProveedor.DisplayMember.ToString();
                
              //  c.CargarComboBoxAnidado(comboBoxLocalidadProveedor, provincia);
                



            }

        }

        private void comboBoxProvinciaProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string provincia = comboBoxProvinciaProveedor.ValueMember;
            //c.CargarComboBoxAnidado(comboBoxLocalidadProveedor, provincia);

        }
    }
}
