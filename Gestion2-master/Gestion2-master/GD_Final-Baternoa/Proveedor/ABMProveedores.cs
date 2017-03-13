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

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Gestion-V2;Persist Security Info=True;User ID=sa;Password=12345");

        public ABMProveedores()
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

            comboBoxProvinciaProveedor.ValueMember = "IdProvincia";
            comboBoxProvinciaProveedor.DisplayMember = "NombreProvincia";
            comboBoxProvinciaProveedor.DataSource = dt;

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

            comboBoxLocalidadProveedor.ValueMember = "IdLocalidad";
            comboBoxLocalidadProveedor.DisplayMember = "NombreLocalidad";
            comboBoxLocalidadProveedor.DataSource = dt;

        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {


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

        }


        private void buttonNuevoP_Click(object sender, EventArgs e)
        {
            string calle = textBoxDireccionP.Text;
            int num = int.Parse(textBoxNumero.Text);
            int local = Convert.ToInt32(comboBoxLocalidadProveedor.SelectedValue);
            string cuit = textBoxCUIT.Text;
            string razon = textBoxRazonSocial.Text;
            string rubro = textBoxRubroP.Text;
            string telefono = textBoxTelefonoP.Text;
            string correo = textBoxCorreoP.Text;

            string sql = "INSERT INTO Domicilio (Calle, Numero, idLocalidad) VALUES ('" + calle + "'," + num + "," + local + ") SELECT SCOPE_IDENTITY();";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string idDom = reader[0].ToString();
            con.Close();

            con.Open();
            string sql2 = "INSERT INTO Proveedor (CUITProveedor, RazonSocial, Rubro, Telefono, CorreoElectronico, idDomicilio) VALUES ('" + cuit + "','" + razon + "','" + rubro + "','" + telefono + "','" + correo + "',"+idDom+")";
            SqlCommand cmd1 = new SqlCommand(sql2);
            cmd1.CommandType = System.Data.CommandType.Text;
            cmd1.Connection = con;
            con.Close();

            if (c.insertar(sql2))
            {
                MessageBox.Show("Registro insertado");
            }

        }
    }
}
