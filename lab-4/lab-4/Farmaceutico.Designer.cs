namespace adm
{
    partial class Farmaceutico
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBien = new System.Windows.Forms.Label();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.grpInf = new System.Windows.Forms.GroupBox();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.cboMedicamentos = new System.Windows.Forms.ComboBox();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtCanDis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.grpInventario = new System.Windows.Forms.GroupBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.grpRea = new System.Windows.Forms.GroupBox();
            this.cboMedicamento = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtCanti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Medicamento = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox_FondoAdmin = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.grpInf.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.grpInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.grpRea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBien
            // 
            this.lblBien.AutoSize = true;
            this.lblBien.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBien.Location = new System.Drawing.Point(338, 22);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(112, 23);
            this.lblBien.TabIndex = 1;
            this.lblBien.Text = "Bienvenido ";
            // 
            // cboOpciones
            // 
            this.cboOpciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Location = new System.Drawing.Point(277, 73);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(225, 27);
            this.cboOpciones.TabIndex = 7;
            this.cboOpciones.Tag = "";
            this.cboOpciones.Text = "Opciones";
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectIndexChanged);
            // 
            // grpInf
            // 
            this.grpInf.Controls.Add(this.pbImagen);
            this.grpInf.Controls.Add(this.grpEliminar);
            this.grpInf.Controls.Add(this.btnImg);
            this.grpInf.Controls.Add(this.btnMo);
            this.grpInf.Controls.Add(this.label4);
            this.grpInf.Controls.Add(this.btnSubir);
            this.grpInf.Controls.Add(this.label3);
            this.grpInf.Controls.Add(this.txtPrecio);
            this.grpInf.Controls.Add(this.lblNom);
            this.grpInf.Controls.Add(this.txtCanDis);
            this.grpInf.Controls.Add(this.label2);
            this.grpInf.Controls.Add(this.txtNom);
            this.grpInf.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInf.Location = new System.Drawing.Point(12, 125);
            this.grpInf.Name = "grpInf";
            this.grpInf.Size = new System.Drawing.Size(776, 162);
            this.grpInf.TabIndex = 8;
            this.grpInf.TabStop = false;
            this.grpInf.Text = "Llene los espacios en blancos";
            this.grpInf.Visible = false;
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.btnEliminar);
            this.grpEliminar.Controls.Add(this.lblEliminar);
            this.grpEliminar.Controls.Add(this.cboMedicamentos);
            this.grpEliminar.Location = new System.Drawing.Point(526, 24);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(217, 100);
            this.grpEliminar.TabIndex = 11;
            this.grpEliminar.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(57, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 28);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(65, 11);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(77, 22);
            this.lblEliminar.TabIndex = 12;
            this.lblEliminar.Text = "Eliminar";
            // 
            // cboMedicamentos
            // 
            this.cboMedicamentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMedicamentos.FormattingEnabled = true;
            this.cboMedicamentos.Location = new System.Drawing.Point(0, 41);
            this.cboMedicamentos.Name = "cboMedicamentos";
            this.cboMedicamentos.Size = new System.Drawing.Size(211, 26);
            this.cboMedicamentos.TabIndex = 11;
            this.cboMedicamentos.Tag = "";
            this.cboMedicamentos.Text = "Medicamentos";
            // 
            // btnImg
            // 
            this.btnImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.Location = new System.Drawing.Point(116, 128);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(135, 28);
            this.btnImg.TabIndex = 19;
            this.btnImg.Text = "Agregar imagen";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnMo
            // 
            this.btnMo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.Location = new System.Drawing.Point(314, 111);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(85, 28);
            this.btnMo.TabIndex = 17;
            this.btnMo.Text = "Modificar";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Visible = false;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio por unidad";
            // 
            // btnSubir
            // 
            this.btnSubir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.Location = new System.Drawing.Point(314, 111);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(85, 28);
            this.btnSubir.TabIndex = 16;
            this.btnSubir.Text = "Enviar";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Visible = false;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad Disponible";
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(405, 80);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 25);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(36, 37);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 17);
            this.lblNom.TabIndex = 9;
            this.lblNom.Text = "Nombre";
            // 
            // txtCanDis
            // 
            this.txtCanDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCanDis.Location = new System.Drawing.Point(405, 34);
            this.txtCanDis.Name = "txtCanDis";
            this.txtCanDis.Size = new System.Drawing.Size(100, 25);
            this.txtCanDis.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imagen";
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(131, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 25);
            this.txtNom.TabIndex = 0;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(69, 293);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(665, 150);
            this.dgvTabla.TabIndex = 9;
            this.dgvTabla.Visible = false;
            this.dgvTabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellClick);
            // 
            // grpInventario
            // 
            this.grpInventario.Controls.Add(this.dgvInventario);
            this.grpInventario.Location = new System.Drawing.Point(18, 105);
            this.grpInventario.Name = "grpInventario";
            this.grpInventario.Size = new System.Drawing.Size(785, 371);
            this.grpInventario.TabIndex = 10;
            this.grpInventario.TabStop = false;
            this.grpInventario.Visible = false;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(16, 19);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(754, 336);
            this.dgvInventario.TabIndex = 0;
            // 
            // grpRea
            // 
            this.grpRea.Controls.Add(this.cboMedicamento);
            this.grpRea.Controls.Add(this.btnActualizar);
            this.grpRea.Controls.Add(this.txtCanti);
            this.grpRea.Controls.Add(this.label5);
            this.grpRea.Controls.Add(this.Label_Medicamento);
            this.grpRea.Location = new System.Drawing.Point(12, 105);
            this.grpRea.Name = "grpRea";
            this.grpRea.Size = new System.Drawing.Size(802, 127);
            this.grpRea.TabIndex = 11;
            this.grpRea.TabStop = false;
            this.grpRea.Visible = false;
            // 
            // cboMedicamento
            // 
            this.cboMedicamento.Location = new System.Drawing.Point(116, 71);
            this.cboMedicamento.Name = "cboMedicamento";
            this.cboMedicamento.Size = new System.Drawing.Size(100, 20);
            this.cboMedicamento.TabIndex = 15;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(457, 60);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 31);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCanti
            // 
            this.txtCanti.Location = new System.Drawing.Point(330, 66);
            this.txtCanti.Name = "txtCanti";
            this.txtCanti.Size = new System.Drawing.Size(100, 20);
            this.txtCanti.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad";
            // 
            // Label_Medicamento
            // 
            this.Label_Medicamento.AutoSize = true;
            this.Label_Medicamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Medicamento.Location = new System.Drawing.Point(107, 35);
            this.Label_Medicamento.Name = "Label_Medicamento";
            this.Label_Medicamento.Size = new System.Drawing.Size(124, 22);
            this.Label_Medicamento.TabIndex = 11;
            this.Label_Medicamento.Text = "Medicamento";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(702, 22);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(127, 44);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox_FondoAdmin
            // 
            this.pictureBox_FondoAdmin.Image = global::lab_4.Properties.Resources.Fondo_Admin1;
            this.pictureBox_FondoAdmin.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox_FondoAdmin.Name = "pictureBox_FondoAdmin";
            this.pictureBox_FondoAdmin.Size = new System.Drawing.Size(856, 529);
            this.pictureBox_FondoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FondoAdmin.TabIndex = 17;
            this.pictureBox_FondoAdmin.TabStop = false;
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbImagen.Location = new System.Drawing.Point(111, 72);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(140, 50);
            this.pbImagen.TabIndex = 20;
            this.pbImagen.TabStop = false;
            // 
            // Farmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 525);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grpRea);
            this.Controls.Add(this.grpInventario);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.grpInf);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.lblBien);
            this.Controls.Add(this.pictureBox_FondoAdmin);
            this.Name = "Farmaceutico";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInf.ResumeLayout(false);
            this.grpInf.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.grpInventario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.grpRea.ResumeLayout(false);
            this.grpRea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.GroupBox grpInf;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCanDis;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.ComboBox cboMedicamentos;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.GroupBox grpRea;
        private System.Windows.Forms.TextBox txtCanti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_Medicamento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox cboMedicamento;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox_FondoAdmin;
    }
}

