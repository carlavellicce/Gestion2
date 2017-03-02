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
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommandBuilder cb;
        SqlDataAdapter da;
        public ABMProveedores()
        {
            InitializeComponent();
        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {


            CargarComboBox();

           


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

        }


    
        private void comboBoxProvinciaProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        public void CargarComboBox()
        {
           
            string cad = "Select idProvincia,NombreProvincia from Provincia ";
            cmd = new SqlCommand(cad, cn);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            dr.Fill(tbl);

            comboBoxProvinciaProveedor.DataSource = tbl;
            comboBoxProvinciaProveedor.ValueMember = "idProvincia";
            comboBoxProvinciaProveedor.DisplayMember = "NombreProvincia";
        }

        public void CargarComboBoxAnidado()
        {
            string idProvincia = comboBoxProvinciaProveedor.ValueMember;
            string cad = "SELECT idLocalidad,NombreLocalidad FROM Localidad WHERE idProvincia = @idProvincia ";
            cmd = new SqlCommand(cad, cn);
            cmd.Parameters.AddWithValue("idProvincia", idProvincia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxLocalidadProveedor.DataSource = dt;
            comboBoxLocalidadProveedor.ValueMember = "idLocalidad";
            comboBoxLocalidadProveedor.DisplayMember = "NombreLocalidad";

        }
    }
}
