namespace GD_Final_Baternoa.Producto
{
    partial class NuevoProducto
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
            this.labelCodigoProducto = new System.Windows.Forms.Label();
            this.labelTipoProducto = new System.Windows.Forms.Label();
            this.labelMarcaProducto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxCodigoP = new System.Windows.Forms.TextBox();
            this.textBoxTipoP = new System.Windows.Forms.TextBox();
            this.textBoxMarcaP = new System.Windows.Forms.TextBox();
            this.textBoxPrecioP = new System.Windows.Forms.TextBox();
            this.textBoxStockP = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCategoriaP = new System.Windows.Forms.Label();
            this.comboBoxCategoriaP = new System.Windows.Forms.ComboBox();
            this.comboBoxCUITProveedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCodigoProducto
            // 
            this.labelCodigoProducto.AutoSize = true;
            this.labelCodigoProducto.Location = new System.Drawing.Point(76, 37);
            this.labelCodigoProducto.Name = "labelCodigoProducto";
            this.labelCodigoProducto.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoProducto.TabIndex = 0;
            this.labelCodigoProducto.Text = "Codigo";
            // 
            // labelTipoProducto
            // 
            this.labelTipoProducto.AutoSize = true;
            this.labelTipoProducto.Location = new System.Drawing.Point(79, 65);
            this.labelTipoProducto.Name = "labelTipoProducto";
            this.labelTipoProducto.Size = new System.Drawing.Size(28, 13);
            this.labelTipoProducto.TabIndex = 1;
            this.labelTipoProducto.Text = "Tipo";
            this.labelTipoProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMarcaProducto
            // 
            this.labelMarcaProducto.AutoSize = true;
            this.labelMarcaProducto.Location = new System.Drawing.Point(76, 99);
            this.labelMarcaProducto.Name = "labelMarcaProducto";
            this.labelMarcaProducto.Size = new System.Drawing.Size(37, 13);
            this.labelMarcaProducto.TabIndex = 2;
            this.labelMarcaProducto.Text = "Marca";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(76, 134);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 3;
            this.labelPrecio.Text = "Precio";
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Location = new System.Drawing.Point(76, 196);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(84, 13);
            this.labelCUIT.TabIndex = 4;
            this.labelCUIT.Text = "CUIT Proveedor";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(81, 225);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 5;
            this.labelStock.Text = "Stock";
            // 
            // textBoxCodigoP
            // 
            this.textBoxCodigoP.Location = new System.Drawing.Point(198, 37);
            this.textBoxCodigoP.Name = "textBoxCodigoP";
            this.textBoxCodigoP.Size = new System.Drawing.Size(121, 20);
            this.textBoxCodigoP.TabIndex = 6;
            // 
            // textBoxTipoP
            // 
            this.textBoxTipoP.Location = new System.Drawing.Point(198, 65);
            this.textBoxTipoP.Name = "textBoxTipoP";
            this.textBoxTipoP.Size = new System.Drawing.Size(121, 20);
            this.textBoxTipoP.TabIndex = 7;
            // 
            // textBoxMarcaP
            // 
            this.textBoxMarcaP.Location = new System.Drawing.Point(198, 96);
            this.textBoxMarcaP.Name = "textBoxMarcaP";
            this.textBoxMarcaP.Size = new System.Drawing.Size(121, 20);
            this.textBoxMarcaP.TabIndex = 8;
            // 
            // textBoxPrecioP
            // 
            this.textBoxPrecioP.Location = new System.Drawing.Point(198, 134);
            this.textBoxPrecioP.Name = "textBoxPrecioP";
            this.textBoxPrecioP.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecioP.TabIndex = 9;
            // 
            // textBoxStockP
            // 
            this.textBoxStockP.Location = new System.Drawing.Point(198, 225);
            this.textBoxStockP.Name = "textBoxStockP";
            this.textBoxStockP.Size = new System.Drawing.Size(121, 20);
            this.textBoxStockP.TabIndex = 11;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(114, 269);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(311, 269);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelCategoriaP
            // 
            this.labelCategoriaP.AutoSize = true;
            this.labelCategoriaP.Location = new System.Drawing.Point(76, 165);
            this.labelCategoriaP.Name = "labelCategoriaP";
            this.labelCategoriaP.Size = new System.Drawing.Size(52, 13);
            this.labelCategoriaP.TabIndex = 14;
            this.labelCategoriaP.Text = "Categoria";
            this.labelCategoriaP.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxCategoriaP
            // 
            this.comboBoxCategoriaP.FormattingEnabled = true;
            this.comboBoxCategoriaP.Location = new System.Drawing.Point(198, 161);
            this.comboBoxCategoriaP.Name = "comboBoxCategoriaP";
            this.comboBoxCategoriaP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoriaP.TabIndex = 15;
            this.comboBoxCategoriaP.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoriaP_SelectedIndexChanged);
            // 
            // comboBoxCUITProveedor
            // 
            this.comboBoxCUITProveedor.FormattingEnabled = true;
            this.comboBoxCUITProveedor.Location = new System.Drawing.Point(198, 189);
            this.comboBoxCUITProveedor.Name = "comboBoxCUITProveedor";
            this.comboBoxCUITProveedor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCUITProveedor.TabIndex = 16;
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 351);
            this.Controls.Add(this.comboBoxCUITProveedor);
            this.Controls.Add(this.comboBoxCategoriaP);
            this.Controls.Add(this.labelCategoriaP);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxStockP);
            this.Controls.Add(this.textBoxPrecioP);
            this.Controls.Add(this.textBoxMarcaP);
            this.Controls.Add(this.textBoxTipoP);
            this.Controls.Add(this.textBoxCodigoP);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelCUIT);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelMarcaProducto);
            this.Controls.Add(this.labelTipoProducto);
            this.Controls.Add(this.labelCodigoProducto);
            this.Name = "NuevoProducto";
            this.Text = "Nuevo Producto";
            this.Load += new System.EventHandler(this.NuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoProducto;
        private System.Windows.Forms.Label labelTipoProducto;
        private System.Windows.Forms.Label labelMarcaProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxCodigoP;
        private System.Windows.Forms.TextBox textBoxTipoP;
        private System.Windows.Forms.TextBox textBoxMarcaP;
        private System.Windows.Forms.TextBox textBoxPrecioP;
        private System.Windows.Forms.TextBox textBoxStockP;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelCategoriaP;
        private System.Windows.Forms.ComboBox comboBoxCategoriaP;
        private System.Windows.Forms.ComboBox comboBoxCUITProveedor;
    }
}