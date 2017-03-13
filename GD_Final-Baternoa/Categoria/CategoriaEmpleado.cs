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

namespace GD_Final_Baternoa.Categoria
{
    public partial class CategoriaEmpleado : Form
    {
        Conexion c = new Conexion();
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Gestion-V2;Persist Security Info=True;User ID=sa;Password=12345");
        public CategoriaEmpleado()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoriaEmpleado_Load(object sender, EventArgs e)
        {

            
            string sql = "SELECT *FROM CategoriaEmpleado";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql);
        }
    }
}
