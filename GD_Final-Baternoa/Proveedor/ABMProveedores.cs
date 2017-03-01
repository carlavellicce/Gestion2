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
        public ABMProveedores()
        {
            InitializeComponent();
        }

        private void ABMProveedores_Load(object sender, EventArgs e)
        {

            c.CargarComboBox(comboBoxProvinciaProveedor);

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
