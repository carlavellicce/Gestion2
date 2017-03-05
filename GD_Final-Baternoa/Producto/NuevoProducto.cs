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

namespace GD_Final_Baternoa.Producto
{
    public partial class NuevoProducto : Form
    {

        Conexion c = new Conexion();
        
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {

            
        }

        private void comboBoxCategoriaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
      
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string agregar = "insert into Producto datos values (" +textBoxCodigoP.Text + ",'"+textBoxTipoP.Text + "','" + textBoxMarcaP + "','" + textBoxPrecioP +"'," + textBoxStockP +"," + comboBoxCategoriaP +", '" +comboBoxCUITProveedor + "')";
            if (c.insertar(agregar))
            {
                MessageBox.Show("Datos agregados");
            }
            else { MessageBox.Show("error"); }
        }
    }
}
