using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GD_Final_Baternoa.Menu
{
    public partial class MenuPrincipal : Form
    {
        Conexion con = new Conexion();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }
        public bool usuarioLogueado = false;
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            con.abrirConexion();
                this.Hide();
            Login login = new Login();
            login.ShowDialog();
            if (login.logueado == true)
            {
                this.Show();
                usuarioLogueado = true;
            }
            else
            {
                this.Close();
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarioLogueado == true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Desea salir del sistema", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
