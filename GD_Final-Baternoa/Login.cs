using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_Final_Baternoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool logueado = false;
        Menu.MenuPrincipal menuppal = new Menu.MenuPrincipal();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logueado = true;

            if (logueado == true)
            {
                MessageBox.Show("Bienvenido usuario", "Mensaje", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("Acceso denegado, intente nuevamente", "Error", MessageBoxButtons.OK);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                txtUsuario.Focus();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
