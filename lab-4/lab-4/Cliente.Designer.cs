namespace lab4
{
    partial class Cliente
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
            this.Label_Total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Label_Carrito = new System.Windows.Forms.Label();
            this.Label_TituloCliente = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Label_Cliente = new System.Windows.Forms.Label();
            this.pictureBox_Fondo_Cliente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fondo_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Total
            // 
            this.Label_Total.AutoSize = true;
            this.Label_Total.BackColor = System.Drawing.Color.PowderBlue;
            this.Label_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Total.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Total.Location = new System.Drawing.Point(706, 381);
            this.Label_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Total.Name = "Label_Total";
            this.Label_Total.Size = new System.Drawing.Size(56, 25);
            this.Label_Total.TabIndex = 17;
            this.Label_Total.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(672, 418);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(117, 33);
            this.txtTotal.TabIndex = 16;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(662, 22);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 39);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Label_Carrito
            // 
            this.Label_Carrito.AutoSize = true;
            this.Label_Carrito.BackColor = System.Drawing.Color.PowderBlue;
            this.Label_Carrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Carrito.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Carrito.Location = new System.Drawing.Point(689, 133);
            this.Label_Carrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Carrito.Name = "Label_Carrito";
            this.Label_Carrito.Size = new System.Drawing.Size(73, 25);
            this.Label_Carrito.TabIndex = 14;
            this.Label_Carrito.Text = "Carrito";
            // 
            // Label_TituloCliente
            // 
            this.Label_TituloCliente.AutoSize = true;
            this.Label_TituloCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.Label_TituloCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_TituloCliente.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TituloCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_TituloCliente.Location = new System.Drawing.Point(189, 22);
            this.Label_TituloCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_TituloCliente.Name = "Label_TituloCliente";
            this.Label_TituloCliente.Size = new System.Drawing.Size(230, 41);
            this.Label_TituloCliente.TabIndex = 13;
            this.Label_TituloCliente.Text = "Farmacia Pana";
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(616, 472);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(215, 35);
            this.btnFinalizarCompra.TabIndex = 12;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(175, 399);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(251, 50);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.Location = new System.Drawing.Point(630, 166);
            this.listBoxCarrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(188, 199);
            this.listBoxCarrito.TabIndex = 10;
            this.listBoxCarrito.DoubleClick += new System.EventHandler(this.listBoxCarrito_DoubleClick);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(11, 170);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 62;
            this.dgvInventario.RowTemplate.Height = 28;
            this.dgvInventario.Size = new System.Drawing.Size(583, 194);
            this.dgvInventario.TabIndex = 9;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            this.dgvInventario.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInventario_DataError);
            // 
            // Label_Cliente
            // 
            this.Label_Cliente.AutoSize = true;
            this.Label_Cliente.BackColor = System.Drawing.Color.PowderBlue;
            this.Label_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cliente.Location = new System.Drawing.Point(57, 88);
            this.Label_Cliente.Name = "Label_Cliente";
            this.Label_Cliente.Size = new System.Drawing.Size(479, 59);
            this.Label_Cliente.TabIndex = 18;
            this.Label_Cliente.Text = "¡Bienvenido a Farmacia Pana!\r\n\r\nPor favor, ingrese los siguientes productos dispo" +
    "nibles a comprar:\r\n";
            this.Label_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Fondo_Cliente
            // 
            this.pictureBox_Fondo_Cliente.Image = global::lab_4.Properties.Resources.Fondo_Cliente;
            this.pictureBox_Fondo_Cliente.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox_Fondo_Cliente.Name = "pictureBox_Fondo_Cliente";
            this.pictureBox_Fondo_Cliente.Size = new System.Drawing.Size(866, 545);
            this.pictureBox_Fondo_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Fondo_Cliente.TabIndex = 19;
            this.pictureBox_Fondo_Cliente.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 540);
            this.Controls.Add(this.Label_Cliente);
            this.Controls.Add(this.Label_Total);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.Label_Carrito);
            this.Controls.Add(this.Label_TituloCliente);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.listBoxCarrito);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pictureBox_Fondo_Cliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fondo_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label Label_Carrito;
        private System.Windows.Forms.Label Label_TituloCliente;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label Label_Cliente;
        private System.Windows.Forms.PictureBox pictureBox_Fondo_Cliente;
    }
}