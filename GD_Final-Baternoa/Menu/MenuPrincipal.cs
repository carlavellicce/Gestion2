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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Cliente.ABMCLienteConsulta ABMConsul = new Cliente.ABMCLienteConsulta();
            ABMConsul.Visible = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedor.ABMProveedorConsulta ABMPC = new Proveedor.ABMProveedorConsulta();
            ABMPC.Visible = true;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado.ABMEmpleados ABME = new Empleado.ABMEmpleados();
            ABME.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Producto.ABMConsulta ABMCP = new Producto.ABMConsulta();
            ABMCP.Visible = true;

        }
    }
}
