﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_Final_Baternoa.Producto
{
    public partial class ABMConsulta : Form
    {
        public ABMConsulta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto NP = new NuevoProducto();
            NP.Visible = true;
        }

        
            }
}
