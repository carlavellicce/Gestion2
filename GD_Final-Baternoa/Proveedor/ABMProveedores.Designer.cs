namespace GD_Final_Baternoa.Proveedor
{
    partial class ABMProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxCUIT = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNuevoP = new System.Windows.Forms.Button();
            this.buttonBuscarP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRubro = new System.Windows.Forms.Label();
            this.textBoxRubroP = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefonoP = new System.Windows.Forms.TextBox();
            this.labelCorreoP = new System.Windows.Forms.Label();
            this.textBoxCorreoP = new System.Windows.Forms.TextBox();
            this.labelDireccionP = new System.Windows.Forms.Label();
            this.textBoxDireccionP = new System.Windows.Forms.TextBox();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProvinciaProveedor = new System.Windows.Forms.ComboBox();
            this.comboBoxLocalidadProveedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCUIT
            // 
            this.textBoxCUIT.Location = new System.Drawing.Point(227, 53);
            this.textBoxCUIT.Name = "textBoxCUIT";
            this.textBoxCUIT.Size = new System.Drawing.Size(116, 20);
            this.textBoxCUIT.TabIndex = 0;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.Location = new System.Drawing.Point(227, 84);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(116, 20);
            this.textBoxRazonSocial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CUIT ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Razón Social";
            // 
            // buttonNuevoP
            // 
            this.buttonNuevoP.Location = new System.Drawing.Point(227, 455);
            this.buttonNuevoP.Name = "buttonNuevoP";
            this.buttonNuevoP.Size = new System.Drawing.Size(100, 23);
            this.buttonNuevoP.TabIndex = 12;
            this.buttonNuevoP.Text = "Nuevo";
            this.buttonNuevoP.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarP
            // 
            this.buttonBuscarP.Location = new System.Drawing.Point(391, 59);
            this.buttonBuscarP.Name = "buttonBuscarP";
            this.buttonBuscarP.Size = new System.Drawing.Size(100, 23);
            this.buttonBuscarP.TabIndex = 14;
            this.buttonBuscarP.Text = "Buscar";
            this.buttonBuscarP.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(47, 455);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 455);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(59, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 61);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Provincia";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Localidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            // 
            // labelRubro
            // 
            this.labelRubro.AutoSize = true;
            this.labelRubro.Location = new System.Drawing.Point(70, 154);
            this.labelRubro.Name = "labelRubro";
            this.labelRubro.Size = new System.Drawing.Size(36, 13);
            this.labelRubro.TabIndex = 18;
            this.labelRubro.Text = "Rubro";
            // 
            // textBoxRubroP
            // 
            this.textBoxRubroP.Location = new System.Drawing.Point(227, 147);
            this.textBoxRubroP.Name = "textBoxRubroP";
            this.textBoxRubroP.Size = new System.Drawing.Size(116, 20);
            this.textBoxRubroP.TabIndex = 19;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(71, 189);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 20;
            this.labelTelefono.Text = "Telefono";
            this.labelTelefono.Click += new System.EventHandler(this.labelTelefono_Click);
            // 
            // textBoxTelefonoP
            // 
            this.textBoxTelefonoP.Location = new System.Drawing.Point(227, 182);
            this.textBoxTelefonoP.Name = "textBoxTelefonoP";
            this.textBoxTelefonoP.Size = new System.Drawing.Size(116, 20);
            this.textBoxTelefonoP.TabIndex = 21;
            // 
            // labelCorreoP
            // 
            this.labelCorreoP.AutoSize = true;
            this.labelCorreoP.Location = new System.Drawing.Point(71, 222);
            this.labelCorreoP.Name = "labelCorreoP";
            this.labelCorreoP.Size = new System.Drawing.Size(38, 13);
            this.labelCorreoP.TabIndex = 22;
            this.labelCorreoP.Text = "Correo";
            // 
            // textBoxCorreoP
            // 
            this.textBoxCorreoP.Location = new System.Drawing.Point(227, 215);
            this.textBoxCorreoP.Name = "textBoxCorreoP";
            this.textBoxCorreoP.Size = new System.Drawing.Size(116, 20);
            this.textBoxCorreoP.TabIndex = 23;
            // 
            // labelDireccionP
            // 
            this.labelDireccionP.AutoSize = true;
            this.labelDireccionP.Location = new System.Drawing.Point(44, 189);
            this.labelDireccionP.Name = "labelDireccionP";
            this.labelDireccionP.Size = new System.Drawing.Size(52, 13);
            this.labelDireccionP.TabIndex = 24;
            this.labelDireccionP.Text = "Direccion";
            // 
            // textBoxDireccionP
            // 
            this.textBoxDireccionP.Location = new System.Drawing.Point(227, 247);
            this.textBoxDireccionP.Name = "textBoxDireccionP";
            this.textBoxDireccionP.Size = new System.Drawing.Size(116, 20);
            this.textBoxDireccionP.TabIndex = 25;
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(402, 250);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(51, 13);
            this.labelProvincia.TabIndex = 26;
            this.labelProvincia.Text = "Provincia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Localidad";
            // 
            // comboBoxProvinciaProveedor
            // 
            this.comboBoxProvinciaProveedor.FormattingEnabled = true;
            this.comboBoxProvinciaProveedor.Location = new System.Drawing.Point(508, 250);
            this.comboBoxProvinciaProveedor.Name = "comboBoxProvinciaProveedor";
            this.comboBoxProvinciaProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvinciaProveedor.TabIndex = 28;
            this.comboBoxProvinciaProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxProvinciaProveedor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProvinciaProveedor_SelectionChangeCommitted);
            // 
            // comboBoxLocalidadProveedor
            // 
            this.comboBoxLocalidadProveedor.FormattingEnabled = true;
            this.comboBoxLocalidadProveedor.Location = new System.Drawing.Point(508, 276);
            this.comboBoxLocalidadProveedor.Name = "comboBoxLocalidadProveedor";
            this.comboBoxLocalidadProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalidadProveedor.TabIndex = 29;
            // 
            // ABMProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 528);
            this.Controls.Add(this.comboBoxLocalidadProveedor);
            this.Controls.Add(this.comboBoxProvinciaProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.textBoxDireccionP);
            this.Controls.Add(this.labelDireccionP);
            this.Controls.Add(this.textBoxCorreoP);
            this.Controls.Add(this.labelCorreoP);
            this.Controls.Add(this.textBoxTelefonoP);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxRubroP);
            this.Controls.Add(this.labelRubro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonBuscarP);
            this.Controls.Add(this.buttonNuevoP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRazonSocial);
            this.Controls.Add(this.textBoxCUIT);
            this.Name = "ABMProveedores";
            this.Text = "ABMProveedores";
            this.Load += new System.EventHandler(this.ABMProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCUIT;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNuevoP;
        private System.Windows.Forms.Button buttonBuscarP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelRubro;
        private System.Windows.Forms.TextBox textBoxRubroP;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefonoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label labelCorreoP;
        private System.Windows.Forms.TextBox textBoxCorreoP;
        private System.Windows.Forms.Label labelDireccionP;
        private System.Windows.Forms.TextBox textBoxDireccionP;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProvinciaProveedor;
        private System.Windows.Forms.ComboBox comboBoxLocalidadProveedor;
    }
}