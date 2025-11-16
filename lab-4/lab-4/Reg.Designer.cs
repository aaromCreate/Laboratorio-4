namespace Registro
{
    partial class Reg
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
            this.Label_TituloRegistro = new System.Windows.Forms.Label();
            this.Label_ConfirmarContra = new System.Windows.Forms.Label();
            this.Label_ContraseñaRegistro = new System.Windows.Forms.Label();
            this.Label_UsuarioRegistro = new System.Windows.Forms.Label();
            this.Registrarbtn = new System.Windows.Forms.Button();
            this.Contraseñatxt = new System.Windows.Forms.TextBox();
            this.Confirmtxt = new System.Windows.Forms.TextBox();
            this.Usuariotxt = new System.Windows.Forms.TextBox();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.Label_Registro = new System.Windows.Forms.Label();
            this.pictureBox_FondoRegistro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_TituloRegistro
            // 
            this.Label_TituloRegistro.AutoSize = true;
            this.Label_TituloRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_TituloRegistro.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TituloRegistro.Location = new System.Drawing.Point(472, 9);
            this.Label_TituloRegistro.Name = "Label_TituloRegistro";
            this.Label_TituloRegistro.Size = new System.Drawing.Size(227, 30);
            this.Label_TituloRegistro.TabIndex = 0;
            this.Label_TituloRegistro.Text = "Registro de usuario";
            // 
            // Label_ConfirmarContra
            // 
            this.Label_ConfirmarContra.AutoSize = true;
            this.Label_ConfirmarContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_ConfirmarContra.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ConfirmarContra.Location = new System.Drawing.Point(395, 194);
            this.Label_ConfirmarContra.Name = "Label_ConfirmarContra";
            this.Label_ConfirmarContra.Size = new System.Drawing.Size(108, 48);
            this.Label_ConfirmarContra.TabIndex = 9;
            this.Label_ConfirmarContra.Text = "Confirmar \r\ncontraseña:";
            // 
            // Label_ContraseñaRegistro
            // 
            this.Label_ContraseñaRegistro.AutoSize = true;
            this.Label_ContraseñaRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_ContraseñaRegistro.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ContraseñaRegistro.Location = new System.Drawing.Point(390, 152);
            this.Label_ContraseñaRegistro.Name = "Label_ContraseñaRegistro";
            this.Label_ContraseñaRegistro.Size = new System.Drawing.Size(113, 25);
            this.Label_ContraseñaRegistro.TabIndex = 10;
            this.Label_ContraseñaRegistro.Text = "Contraseña:";
            // 
            // Label_UsuarioRegistro
            // 
            this.Label_UsuarioRegistro.AutoSize = true;
            this.Label_UsuarioRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_UsuarioRegistro.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UsuarioRegistro.Location = new System.Drawing.Point(418, 112);
            this.Label_UsuarioRegistro.Name = "Label_UsuarioRegistro";
            this.Label_UsuarioRegistro.Size = new System.Drawing.Size(85, 25);
            this.Label_UsuarioRegistro.TabIndex = 12;
            this.Label_UsuarioRegistro.Text = "Usuario:";
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold);
            this.Registrarbtn.Location = new System.Drawing.Point(535, 272);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Size = new System.Drawing.Size(162, 47);
            this.Registrarbtn.TabIndex = 15;
            this.Registrarbtn.Text = "Registrar";
            this.Registrarbtn.UseVisualStyleBackColor = true;
            this.Registrarbtn.Click += new System.EventHandler(this.Registrarbtn_Click);
            // 
            // Contraseñatxt
            // 
            this.Contraseñatxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñatxt.Location = new System.Drawing.Point(518, 156);
            this.Contraseñatxt.Name = "Contraseñatxt";
            this.Contraseñatxt.Size = new System.Drawing.Size(210, 21);
            this.Contraseñatxt.TabIndex = 20;
            // 
            // Confirmtxt
            // 
            this.Confirmtxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmtxt.Location = new System.Drawing.Point(518, 210);
            this.Confirmtxt.Name = "Confirmtxt";
            this.Confirmtxt.Size = new System.Drawing.Size(210, 21);
            this.Confirmtxt.TabIndex = 21;
            // 
            // Usuariotxt
            // 
            this.Usuariotxt.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariotxt.Location = new System.Drawing.Point(518, 115);
            this.Usuariotxt.Name = "Usuariotxt";
            this.Usuariotxt.Size = new System.Drawing.Size(210, 21);
            this.Usuariotxt.TabIndex = 23;
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbtn.Location = new System.Drawing.Point(535, 347);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(162, 47);
            this.Cerrarbtn.TabIndex = 27;
            this.Cerrarbtn.Text = "Cerrar";
            this.Cerrarbtn.UseVisualStyleBackColor = true;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // Label_Registro
            // 
            this.Label_Registro.AutoSize = true;
            this.Label_Registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Registro.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Registro.Location = new System.Drawing.Point(432, 61);
            this.Label_Registro.Name = "Label_Registro";
            this.Label_Registro.Size = new System.Drawing.Size(288, 25);
            this.Label_Registro.TabIndex = 29;
            this.Label_Registro.Text = "Ingrese los siguientes datos \r\n";
            // 
            // pictureBox_FondoRegistro
            // 
            this.pictureBox_FondoRegistro.Image = global::lab_4.Properties.Resources.Fondo_Registro;
            this.pictureBox_FondoRegistro.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox_FondoRegistro.Name = "pictureBox_FondoRegistro";
            this.pictureBox_FondoRegistro.Size = new System.Drawing.Size(788, 427);
            this.pictureBox_FondoRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FondoRegistro.TabIndex = 28;
            this.pictureBox_FondoRegistro.TabStop = false;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 422);
            this.Controls.Add(this.Label_Registro);
            this.Controls.Add(this.Cerrarbtn);
            this.Controls.Add(this.Usuariotxt);
            this.Controls.Add(this.Confirmtxt);
            this.Controls.Add(this.Contraseñatxt);
            this.Controls.Add(this.Registrarbtn);
            this.Controls.Add(this.Label_UsuarioRegistro);
            this.Controls.Add(this.Label_ContraseñaRegistro);
            this.Controls.Add(this.Label_ConfirmarContra);
            this.Controls.Add(this.Label_TituloRegistro);
            this.Controls.Add(this.pictureBox_FondoRegistro);
            this.Name = "Reg";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FondoRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_TituloRegistro;
        private System.Windows.Forms.Label Label_ConfirmarContra;
        private System.Windows.Forms.Label Label_ContraseñaRegistro;
        private System.Windows.Forms.Label Label_UsuarioRegistro;
        private System.Windows.Forms.Button Registrarbtn;
        private System.Windows.Forms.TextBox Contraseñatxt;
        private System.Windows.Forms.TextBox Confirmtxt;
        private System.Windows.Forms.TextBox Usuariotxt;
        private System.Windows.Forms.Button Cerrarbtn;
        private System.Windows.Forms.PictureBox pictureBox_FondoRegistro;
        private System.Windows.Forms.Label Label_Registro;
    }
}

